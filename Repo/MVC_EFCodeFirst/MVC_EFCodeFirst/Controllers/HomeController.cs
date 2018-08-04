using MVC_EFCodeFirst.Content;
using MVC_EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_EFCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        BlogContext context = new BlogContext();

        public ActionResult Index()
        {
            return View(context.Blogs.ToList());
        }

        public ActionResult Create()
        {           
            return View();
        }

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {C:\Users\pratik\Documents\Visual Studio 2015\Projects\C#Batch\MVC_EFCodeFirst\MVC_EFCodeFirst\Views\
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}