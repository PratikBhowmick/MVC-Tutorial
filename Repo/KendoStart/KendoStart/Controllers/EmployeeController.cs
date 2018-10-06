using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoStart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoStart.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmployeeList([DataSourceRequest]DataSourceRequest request)
        {
            try
            {
                List<Employee> _emp = new List<Employee>();
                _emp.Add(new Employee(1, "Bobb", "Ross"));
                _emp.Add(new Employee(2, "Pradeep", "Raj"));
                _emp.Add(new Employee(3, "Arun", "Kumar"));
                _emp.Add(new Employee(4, "Ankan", "Sen"));
                _emp.Add(new Employee(5, "Rishav", "Singh"));
                DataSourceResult result = _emp.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }
    }
}