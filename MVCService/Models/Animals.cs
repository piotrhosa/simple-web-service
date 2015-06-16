using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace MVCService.Models
{
    public class Animals
    {
        public List<string> AnimalList { get; set; }
        public string AnimalHtmlList { get; set;  }

        public Animals(List<string> animalList) 
        {
            AnimalList = animalList;
            AnimalHtmlList = ToHtml(AnimalList);
        }

        private string ToHtml(List<string> animalList)
        {
            StringBuilder outputString = new StringBuilder("", 100);

            foreach (string a in animalList)
            {
                outputString.Append(a);
                outputString.Append("<br>");
            }

            return outputString.ToString();
        }
    }
}