using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice_MVC_Sir_Nadeem.Models;

namespace Practice_MVC_Sir_Nadeem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Class1 Name = new Models.Class1();
            Name.name = "Bilal";
            Name.id = 101;
            ViewBag.Class1 = Name;
            return View();
        }

    }
}