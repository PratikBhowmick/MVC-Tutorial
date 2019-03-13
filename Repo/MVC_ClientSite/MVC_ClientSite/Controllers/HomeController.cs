using MVC_ClientSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ClientSite.EmployeeMappingServiceReference;
using System.Net;

namespace MVC_ClientSite.Controllers
{
    public class HomeController : Controller
    {
        EmployeeClient client = new EmployeeClient();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: /Employee/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Salary,DeptartmentName,Designation")] EmployeeModel employee)
        {
            bool added = false;
            if (ModelState.IsValid)
            {
                //map to WCF data contract
                EmployeeInfo info = new EmployeeInfo()
                {
                    EmpName = employee.Name,
                    DeptName = employee.DeptartmentName,
                    Salary = employee.Salary,
                    Designation = employee.Designation
                };
                added = client.AddEmployee(info);
            }

            if (added)
            {
                ViewBag.Added = true;
            }

            return View();
        }

        public ActionResult Details(int? id)
        {
            EmployeeModel emp = null;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            EmployeeInfo employee = client.GetEmployee(id.Value);

            if (employee != null)
            {
                emp = new EmployeeModel()
                {
                    Name = employee.EmpName,
                    Salary = employee.Salary,
                    Designation = employee.Designation,
                    DeptartmentName = employee.DeptName
                };
            }
            return View(emp);
        }
    }
}
