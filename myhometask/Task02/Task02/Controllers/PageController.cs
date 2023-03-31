using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task02.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About() { 
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Signup () {
        return View();

        }
            public ActionResult LoginSubmit()
        {
            TempData["Msg"] = "Login Successfull";
            return RedirectToAction("Index", "Dashboard");
            
        }

    }
}