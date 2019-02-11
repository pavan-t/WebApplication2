using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult Index()
        {
            List<Department> departments = null;
            using (var context = new EmployeeContext())
            {
                departments = context.Department.ToList();
            }
                return View(departments);
        }
    }
}