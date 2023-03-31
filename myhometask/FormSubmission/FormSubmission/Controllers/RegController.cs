﻿using FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace FormSubmission.Controllers
{
    public class RegController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index( Register model )
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}