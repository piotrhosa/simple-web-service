using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;

namespace SimpleWebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "https://int.scottlogic.co.uk/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Welcome()
        {
            return "Welcome";
        }

        [WebMethod]
        public string DoCoolStuff() 
        {
            return "I'm doing cool stuff.";
        }

        [WebMethod]
        public int DoSomeCalculation(int a, int b)
        {
            return a + b;
        }

        [WebMethod(Description="Selects string from a collection.")]
        public List<string> SelectStringsLargerThan(int minLength)
        {
            List<string> animals = new List<string> { "ox", "bat", "cat", "caterpillar", "hippopotamus" };
            List<string> retAnimals = new List<string>(animals.Count);

            var lenQuery = from a in animals where a.Length >= minLength select a;

            foreach(string a in lenQuery)
                retAnimals.Add(a);
          

            return retAnimals;
        }

        /*
        [WebMethod(Description="Selects from an xml file.")]
        public string SelectBySex(string sex)
        {
            XElement employees = XElement.Load(@"C:\Users\phosa\Documents\Visual Studio 2013\Projects\SimpleWebService\SimpleWebService\employees.xml");

            List<XElement> retEm = new List<XElement>(100);

            IEnumerable<XElement> emQuery = from em in employees.Elements("Employee") where (string)employees.Element("Sex") == sex select em;

            foreach (XElement em in emQuery)
                Console.Out.WriteLine((string)em);

            return "something";
        }
        */

    }
}
