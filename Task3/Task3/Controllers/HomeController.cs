using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee();
            emp.emp_id = 1037;
            emp.emp_name = "Sir Affan";
            emp.emp_department = "DBMS";
            ViewBag.Employee = emp;

            studend std = new studend();
            std.std_id = 9867;
            std.std_name = "Bilal";
            std.std_department = "CoCIS";
            ViewBag.studend = std;
            return View();
        }
    }
    public class Employee
    {
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public string emp_department { get; set; }

    }
    public class studend
    {
        public int std_id { get; set; }
        public string std_name { get; set; }
        public string std_department { get; set; }

    }
}