using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Feb1_Lab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            ViewBag.Message = "HomePage of our Website";
            return View();
        }

        public ActionResult Products()
        {
           

            return View();
        }

        public ActionResult Login()
        {
            

            return View();
        }

        public ActionResult LoginSubmit()
        {

            TempData["Msg"] = "Login Successfull";
            return RedirectToAction ("Profile","Dashboard");
        }
    }
}