using MVC_DataAnnotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DataAnnotation.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegisterAnn reg)
        {
            if (ModelState.IsValid)
            {
                //If all validations pass
                return RedirectToAction("Index", "Registration");
            }

            return View(reg);
        }
    }
}