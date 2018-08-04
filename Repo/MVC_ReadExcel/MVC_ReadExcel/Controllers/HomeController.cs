using MVC_ReadExcel.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ReadExcel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ReadExcel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ReadExcel(HttpPostedFileBase upload)
        {
            List<Employee> employess = new List<Employee>();
            if (Path.GetExtension(upload.FileName) == ".xlsx" || Path.GetExtension(upload.FileName) == ".xls")
            {
                ExcelPackage package = new ExcelPackage(upload.InputStream);
                DataTable Dt = ExcelPackageExtension.ToDataTable(package);

                if (Dt != null)
                {
                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {
                        Employee emp = new Employee();
                        emp.Name = Dt.Rows[i]["Name"].ToString();
                        emp.Email = Dt.Rows[i]["Email"].ToString();
                        emp.Mobile = Dt.Rows[i]["Mobile"].ToString();
                        employess.Add(emp);
                    }
                    TempData["EmployeeList"] = employess;
                    return RedirectToAction("DisplayResult");
                }
            }
            return View();
        }

        public ActionResult DisplayResult()
        {
            List<Employee> listofEmp = TempData["EmployeeList"] as List<Employee>;
            return View(listofEmp);
        }

        public ActionResult Export()
        {
            if(TempData["Sucess"]!= null)
            ViewBag.Message = TempData["Sucess"].ToString();

            return View();
        }

        [HttpPost]
        public ActionResult Export(HttpPostedFileBase upload)
        {
            var con = ConfigurationManager.ConnectionStrings["Yourconnection"].ToString();
            DataTable DT = new DataTable();

            using (SqlConnection myConnection = new SqlConnection(con))
            {
                SqlDataAdapter Adp = new SqlDataAdapter("select * from students", myConnection);
                Adp.Fill(DT);
            }

            if (DT.Rows.Count > 0)
            {
                string filePath = Server.MapPath("~/Content/ExportedExcel.xlxs");
                FileInfo Files = new FileInfo(filePath);
                ExcelPackage excel = new ExcelPackage(Files);
                var sheetCreate = excel.Workbook.Worksheets.Add("Studentdata");

                for (int i = 0; i < DT.Columns.Count; i++)
                {
                    sheetCreate.Cells[1, i + 1].Value = DT.Columns[i].ColumnName.ToString();
                }
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    for (int j = 0; j < DT.Columns.Count; j++)
                    {
                        sheetCreate.Cells[i + 2, j + 1].Value = DT.Rows[i][j].ToString();
                    }
                }
                excel.Save();
            }
            TempData["Sucess"] = true;
            return RedirectToAction("Export");
        }
    }
}