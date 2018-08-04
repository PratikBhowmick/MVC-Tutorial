using OrganizationDetails.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OrganizationDetails.DataAccess
{
    public class DAL
    {

        public void InsertEmployee(Employee emp)
        {
            string connetionString = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString; 
            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand com = new SqlCommand("cp_InsertEmployee", con);  //creating  SqlCommand  object
            con.Open();
            com.CommandType = CommandType.StoredProcedure;  //here we declaring command type as stored Procedure

            com.Parameters.AddWithValue("@LastName", emp.LastName.ToString());
            com.Parameters.AddWithValue("@FirstName", emp.FirstName.ToString());
            com.Parameters.AddWithValue("@JoiningDate", emp.JoiningDate.ToString());
            com.ExecuteNonQuery();
            con.Close();
        }

        public Employee GetEmployee(int id)
        {
            string connetionString = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
            Employee emp = new Employee();
            using (SqlConnection myConnection = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand("cp_GetEmployee", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    myConnection.Open();

                    SqlParameter custId = cmd.Parameters.AddWithValue("@EmployeeID", id);                   
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            emp.EmployeeID = int.Parse(dr["EmployeeID"].ToString());
                            emp.LastName = dr["LastName"].ToString();
                            emp.FirstName = dr["FirstName"].ToString();
                            emp.JoiningDate = Convert.ToDateTime(dr["JoiningDate"].ToString());
                        }
                    }
                }
            }
            return emp;
        }
    }
}
