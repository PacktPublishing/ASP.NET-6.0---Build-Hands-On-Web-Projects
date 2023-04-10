using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreStateManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreStateManagement.Controllers
{
    public class UserDetailsController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "Emily");
            HttpContext.Session.SetString("Gender", "Female");
            HttpContext.Session.SetString("Department", "Human Resources");
            HttpContext.Session.SetInt32("Pay", 4500);
            return View();
        }

        public IActionResult Get()
        {
            Employee emp = new Employee()
            {
                Name = HttpContext.Session.GetString("Name"),
                Gender = HttpContext.Session.GetString("Gender"),
                Department = HttpContext.Session.GetString("Department"),
                Pay = HttpContext.Session.GetInt32("Pay").Value

            };
            return View(emp);
         }

        public IActionResult GetQueryString(string name, string gender, string department, Int32 pay)
        {
            Employee employee = new Employee()
            {
                Name = name,
                Gender = gender,
                Department = department,
                Pay = pay

            };
            return View(employee); 
        }

        [HttpGet]
        public IActionResult HiddenFieldSet()
        {
            Employee emp = new Employee()
            {
                Name = "Maya",
                Department = "Mktg",
                Gender = "F",
                Pay = 5600
            };
            return View(emp);
        }
        [HttpPost]
        public IActionResult HiddenFieldSet(IFormCollection keys)
        {
            var name = keys["Name"];
            return View();
        }
    }
}
