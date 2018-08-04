using MVC_DataAnnotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DataAnnotation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }      

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Register reg)
        {
            if(string.IsNullOrEmpty(reg.UserName))
            {
                ModelState.AddModelError("UserName", "User Name is required");
            }
            if (string.IsNullOrEmpty(reg.Password))
            {
                ModelState.AddModelError("Password", "Password is required");
            }
            if (string.IsNullOrEmpty(reg.ConfirmPassword))
            {
                ModelState.AddModelError("ConfirmPassword", "ConfirmPassword is required");
            }

            if(ModelState.IsValid)
            {
                //If all validations pass
                return RedirectToAction("Register", "Home");
            }

            return View(reg);
        }
    }
}