using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ViewDataTempData.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Sample()
        {
            ViewData["CurrentdateTime"] = DateTime.Now;

            ViewBag.Name = "Besant Technologies";

            TempData["temp"] = "MVC";

            Session["sess"] = "Alive";

            return RedirectToAction("RedirectAction");
            //return View();
        }

        public ActionResult Demo()
        {
            List<string> cnt = new List<string>()
            {
                "India",
                "Russia",
                "England"
            };

            ViewData["countries"] = cnt;

            return View();
        }

        public ActionResult RedirectAction()
        {
            //Doesnt gets value
            string strViewBag = ViewBag.Name;

            //Doesnt gets value
            string strViewData = (ViewData["CurrentdateTime"]!=null) ? ViewData["CurrentdateTime"].ToString() : null;

            //Gets value
            string strTempData = TempData["temp"].ToString();

            return View();
        }
    }
}