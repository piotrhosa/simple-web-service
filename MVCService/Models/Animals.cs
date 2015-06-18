using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace MVCService.Models
{
    public class Animals
    {
        public List<Animal> AnimalList { get; set; }
        public string AnimalHtmlList { get; set;  }

        public Animals(List<Animal> animalList) 
        {
            AnimalList = animalList;
            AnimalHtmlList = ToHtml(AnimalList);
        }

        private string ToHtml(List<Animal> animalList)
        {
            StringBuilder outputString = new StringBuilder("", 100);

            foreach (Animal a in animalList)
            {
                outputString.Append(a.Type);
                outputString.Append("<br>");
            }

            return outputString.ToString();
        }
    }
}