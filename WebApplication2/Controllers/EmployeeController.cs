using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeContext context = new EmployeeContext();
            var emps = context.Employees.ToList();
            return View(emps);
        }
        // GET: Employee
        public ActionResult Details(int? id)
        {
            EmployeeContext context = new EmployeeContext();
           var emp = context.Employees.Single(e => e.EmployeeId == id);
            return View(emp);
        }
    }
}