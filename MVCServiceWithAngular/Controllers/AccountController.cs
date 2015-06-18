using MVCServiceWithAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;

namespace MVCServiceWithAngular.Controllers
{
    [System.Web.Http.Authorize]
    public class AccountController : Controller
    {
        [System.Web.Http.AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }


    }
}
