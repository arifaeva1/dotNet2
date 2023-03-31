using FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
       
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        
      public ActionResult Index(Login model )
        {
            

            return View( model);
          

        }
        public ActionResult About() {
            
            


            return View();


        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}