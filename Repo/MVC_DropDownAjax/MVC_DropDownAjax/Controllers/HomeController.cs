using MVC_DropDownAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DropDownAjax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("ViewDepartment");
        }

        public JsonResult GetAllDepartments()
        {
            List<Department> listOfDept = new List<Department>();

            Department dept1 = new Department()
            {
                Id = 1,
                Name = "Finance"
            };
            Department dept2 = new Department()
            {
                Id = 1,
                Name = "IT"
            };
            Department dept3 = new Department()
            {
                Id = 1,
                Name = "Admin"
            };
            Department dept4 = new Department()
            {
                Id = 1,
                Name = "Travel"
            };

            listOfDept.Add(dept1);
            listOfDept.Add(dept2);
            listOfDept.Add(dept3);
            listOfDept.Add(dept4);

            return Json(listOfDept, JsonRequestBehavior.AllowGet);
        }        
    }
}