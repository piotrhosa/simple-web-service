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
        private DatabaseEntities db = new DatabaseEntities();

        private void AddAnimalToDatabase(Animal animal) {

        }

        public ActionResult AddNewAnimal()
        {
            string name = Request["name"].ToString();
            string type = Request["type"].ToString();
            int age = Convert.ToInt32(Request["age"].ToString());

            Animal newAnimal = new Animal(name, type, age);

            db.Animals.Add(newAnimal);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                db.SaveChanges();
            }

            //OperationDataContext context
            //This would need System.Data.Linq to be added.

            return Content(newAnimal.ToString());
        }


    }
}
