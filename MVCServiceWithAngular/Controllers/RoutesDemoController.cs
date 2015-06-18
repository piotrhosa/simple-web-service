﻿using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MVCServiceWithAngular.Controllers
{
    public class RoutesDemoController : Controller
    {
        public ActionResult One()
        {
            return View();
        }

        public ActionResult Two(int donuts = 1)
        {
            ViewBag.Donuts = donuts;
            return View();
        }

        [Authorize]
        public ActionResult Three()
        {
            return View();
        }
    }
}
