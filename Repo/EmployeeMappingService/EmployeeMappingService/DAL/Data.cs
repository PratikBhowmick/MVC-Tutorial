using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMappingService.DAL
{
    public class Data
    {
        public EmployeeInfo GetEmployee(int id)
        {
            string connetionString = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
            EmployeeInfo emp = new EmployeeInfo();
            using (SqlConnection myConnection = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM EmployeeInfo WHERE EmpNo =" + id, myConnection))
                {
                    cmd.CommandType = CommandType.Text;
                    myConnection.Open();                    
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            emp.EmpNo = int.Parse(dr["EmpNo"].ToString());
                            emp.EmpName = dr["EmpName"].ToString();
                            emp.Designation = dr["Designation"].ToString();
                            emp.DeptName = dr["DeptName"].ToString();
                            emp.Salary = int.Parse(dr["Salary"].ToString());
                        }
                    }
                }
            }
            return emp;
        }

        public bool AddEmployee(EmployeeInfo employee)
        {
            int added = 0;
            string connetionString = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand com = new SqlCommand("INSERT INTO [dbo].[EmployeeInfo] ([EmpName], [Salary], [DeptName], [Designation]) VALUES ('"+employee.EmpName+"',"+employee.Salary+",'"+employee.DeptName + "','" +employee.Designation + "')", con); 
            con.Open();
                        
            added = com.ExecuteNonQuery();
            con.Close();

            if(added > 0)
            {
                return true;
            }
            return false;
        }
    }
}
