using MVCService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MVCService.Controllers
{
    public class AddController : Controller
    {
        //private DatabaseEntities db = new DatabaseEntities();

        [System.Web.Mvc.HttpPost]
        public ActionResult AddNewAnimal()
        {
            string name = Request["name"].ToString();
            string type = Request["type"].ToString();
            int age = Convert.ToInt32(Request["age"].ToString());

            Animal newAnimal = new Animal(name, type, age);

            DatabaseEntities db = new DatabaseEntities();

            try
            {
                db.Animals.Add(newAnimal);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return View("Error writing to database: " + e.ToString());
            }

            //This is how you can remove entries from the database.
            //Animal entryToBeDeleted = db.Animals.First(x => x.Name == "Mama");
            //db.Animals.Remove(entryToBeDeleted);
            //db.SaveChanges();

            //This is to refresh the page so that the table reloads from database
            return RedirectToAction("Add", "Home");
            
        }
    }
}
