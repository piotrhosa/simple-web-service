using MVCService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Message = "Here you can search animals by name length.";
            return View();
        }

        //private WebServicesDbEntities1 db = new WebServicesDbEntities1();

        public ActionResult Add()
        {
            ViewBag.Message = "You can add a new animal to the family here.";
            //return View(db.Animal.ToList());
            return View();
        }
    }
}