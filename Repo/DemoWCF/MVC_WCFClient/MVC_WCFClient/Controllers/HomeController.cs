using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WCFClient.Controllers
{
    public class HomeController : Controller
    {
        ClientAuthorReference.Service1Client service = new ClientAuthorReference.Service1Client();

        public ActionResult Index()
        {
            DataSet ds = service.ReturnAuthor();
            ViewBag.AuthorList = ds.Tables[0];
            return View();
        }
    }
}