using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lyout.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            ViewBag.title = "Index";
            return View();
        }
        public ActionResult Myprofile()
        {
            ViewBag.title = "Profile";
            ViewBag.name = "eVA";
            ViewBag.section = " c";
           
            return View();  
        }
        public ActionResult Settings()
        {
            ViewBag.title = "settings";
            return View();
        }
        public ActionResult Logout() {

             return RedirectToAction("Home","Page");   
        }
    }
}