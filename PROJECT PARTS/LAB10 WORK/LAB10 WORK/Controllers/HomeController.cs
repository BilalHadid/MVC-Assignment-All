using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LAB10_WORK.Models;
namespace LAB10_WORK.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            mod md = new Models.mod();
            md.FirstName = "Muhammad";
            md.LastName = "Ghufran";
            md.Age = 21;
            return View(md);
          
        }
        public ActionResult Create(string FirstName,string LastName,int Age)
        {
            mod abc = new mod();
            abc.FirstName = FirstName;
            abc.LastName = LastName;
            abc.Age = Age;
            return View(abc);
        }

    }
}