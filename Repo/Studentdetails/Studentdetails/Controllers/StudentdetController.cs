using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Studentdetails.Models;

namespace Studentdetails.Controllers
{
    public class StudentdetController : Controller
    {
        sampledbcontext db = new sampledbcontext();

        // GET: Studentdet
        public ActionResult Index()
        {           
            return View();
        }

        public PartialViewResult _student_all()
        {
            List<student> student_dtls = db.students.ToList();
            return PartialView ("_student_all",student_dtls);
        }

        public PartialViewResult _student_top3()
        {
            List<student> student_dtls = db.students.OrderByDescending(t => t.Marks).Take(3).ToList();
            return PartialView("_student_all", student_dtls);
        }

        public PartialViewResult _student_bottom3()
        {
            List<student> student_dtls = db.students.OrderBy(m=>m.Marks).Take(3).ToList();
            return PartialView("_student_all", student_dtls);
        }

    }
}