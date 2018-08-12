using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebPattern.Models;

namespace WebPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "Vasia",
                Age = 22
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Ne Vasia",
                Age = 40
            }
        };

        public IActionResult Index()
        {
            //return Content("test");
            return View(_employees);
        }
    }
}