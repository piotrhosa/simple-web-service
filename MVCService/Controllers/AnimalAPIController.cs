using MVCService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCService.Controllers
{
    public class AnimalAPIController : ApiController
    {

    //    public IHttpActionResult GetProduct(int id)
    //    {
    //        int minLength = id;

    //        List<string> queryList = (List<string>)CreateNewList(minLength);


    //        //StringBuilder outputString = new StringBuilder("", 100);

    //        //foreach (string a in queryList)
    //        //{
    //        //    outputString.Append(a);
    //        //    outputString.Append("<br>");
    //        //}

    //        //string someString = "string";

    //        return Ok( new Animals(queryList));

    //    }


    //    public List<string> CreateNewList(int minLength)
    //    {
    //        List<string> retAnimals = new List<string>(animals.Count);

    //        var lenQuery = from a in animals where a.Length >= minLength select a;

    //        foreach (string a in lenQuery)
    //            retAnimals.Add(a);

    //        return retAnimals;
    //    }


    //    public List<string> animals = new List<string> { "ox", "cat", "caterpillar", "hippopotamus" };
    //
    }
}
