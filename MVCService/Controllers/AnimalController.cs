using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Text;
using MVCService.Models;

namespace MVCService.Controllers
{
    public class AnimalController : Controller
    {


        //public List<Animal> animals = new List<Animal> 
        //{ 
        //    new Animal("Dan", "Dog", 2),
        //    new Animal("Don", "Badger", 4),
        //    new Animal("Ben", "Crow", 1)
        //};
    
        //public List<Animal> GetAllAnimals()
        //{
        //    return animals;
        //}

        //public List<Animal> CreateNewList(int minLength)
        //{
        //    List<Animal> retAnimals = new List<Animal>(animals.Count);

        //    var lenQuery = from a in animals where a.Name.Length >= minLength select a;

        //    foreach (Animal a in lenQuery)
        //        retAnimals.Add(a);

        //    return retAnimals;
        //}

        [System.Web.Mvc.HttpPost]
        public ActionResult GetAnimalNamesLongerThan()
        {

            int minLength = Convert.ToInt32(Request["minLength"].ToString());

            DatabaseEntities db = new DatabaseEntities();
            var selectedAnimals = (from a in db.Animals where a.Type.Length > minLength select a).ToList();

            Animals aList = new Animals(selectedAnimals);

            //return View(selectedAnimals);
            //return Content(aList.AnimalHtmlList);
            return RedirectToAction("Search", "Home");
        }

    }
}
