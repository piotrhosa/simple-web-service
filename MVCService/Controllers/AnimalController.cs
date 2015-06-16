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
        public List<string> animals = new List<string> { "ox", "cat", "caterpillar", "hippopotamus" };

        public List<string> GetAllAnimals()
        {
            return animals;
        }

        public List<string> CreateNewList(int minLength)
        {
            List<string> retAnimals = new List<string>(animals.Count);

            var lenQuery = from a in animals where a.Length >= minLength select a;

            foreach (string a in lenQuery)
                retAnimals.Add(a);

            return retAnimals;
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult GetAnimalNamesLongerThan()
        {
            int minLength = Convert.ToInt32(Request["minLength"].ToString());

            List<string> queryList = (List<string>)CreateNewList(minLength);

            return Content((new Animals(queryList)).AnimalHtmlList);
        }

    }
}
