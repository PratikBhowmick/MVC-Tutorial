using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_AjaxDemo.Models;

namespace MVC_AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        SampleDBContext db = new SampleDBContext();

        public ActionResult Index()
        {
            return View();
        }        

        public PartialViewResult All()
        {
            List<student> model = db.students.ToList();
            return PartialView("_Student", model);
        }

        public PartialViewResult Top3()
        {
            List<student> model = db.students.OrderByDescending(s=>s.Marks).Take(3).ToList();
            return PartialView("_Student", model);
        }

        public PartialViewResult Bottom3()
        {
            List<student> model = db.students.OrderBy(s => s.Marks).Take(3).ToList();
            return PartialView("_Student", model);
        }
    }
}