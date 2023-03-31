using Feb1_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Feb1_Lab.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Profile()
        {
            Product[] Products = new Product[10];
            for (int i = 0; i < 10; i++)
            {
                Product P = new Product();
                {
                    P.Id = i;
                    P.Name = "P" + i;
                    Products[i] = P;
                };
            }
            ViewBag.Product = Products;
            return View();
        }
        

        public ActionResult Logout()
        {
            return RedirectToAction("Home","Home");
        }
    }
}