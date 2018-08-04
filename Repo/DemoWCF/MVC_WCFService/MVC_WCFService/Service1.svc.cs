using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MVC_WCFService
{
    public class Service1 : IService1
    {
        public void DoWork()
        {
        }


        public DataSet ReturnAuthor()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Author");
            DataColumn dc1 = new DataColumn("AuthorId", typeof(Int32));
            DataColumn dc2 = new DataColumn("Name", typeof(string));
            DataColumn dc3 = new DataColumn("Location", typeof(string));

            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            DataRow dr1 = dt.NewRow();
            dr1[0] = 10;
            dr1[1] = "Krishna Garad";
            dr1[2] = "India";
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2[0] = 20;
            dr2[1] = "Mahesh Chand";
            dr2[2] = "USA";
            dt.Rows.Add(dr2);
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
