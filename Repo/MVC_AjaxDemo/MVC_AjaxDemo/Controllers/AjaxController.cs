using MVC_AjaxDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_AjaxDemo.Controllers
{
    public class AjaxController : Controller
    {
        static List<Product> prodList = new List<Product>();
        //
        // GET: /Ajax/

        public ActionResult Index()
        {
            Product p1 = new Product { ProdCode = "P001", ProdName = "Mobile", ProdQty = 75 };
            Product p2 = new Product { ProdCode = "P002", ProdName = "Laptop", ProdQty = 125 };
            Product p3 = new Product { ProdCode = "P003", ProdName = "Netbook", ProdQty = 100 };
            prodList.Add(p1);
            prodList.Add(p2);
            prodList.Add(p3);
            return View();
        }

        public PartialViewResult ShowDetails()
        {
            System.Threading.Thread.Sleep(3000);
            string code = Request.Form["txtCode"];
            Product prod = new Product();
            foreach (Product p in prodList)
            {
                if (p.ProdCode == code)
                {
                    prod = p;
                    break;
                }
            }
            return PartialView("_ShowDetails", prod);
        }
    }
}