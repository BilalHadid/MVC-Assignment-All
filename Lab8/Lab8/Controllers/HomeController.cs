using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab8.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["result"] = "0";
            return View();
        }
        [HttpPost]
        public ActionResult Index(decimal FNumbeer,decimal SNumbeer)
        {
            decimal result = FNumbeer + SNumbeer;
            ViewData["result"] = result;
            return View();
        }
    }
}