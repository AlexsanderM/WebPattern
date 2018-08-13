using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebPattern.Infrastructure;
using WebPattern.Models;

namespace WebPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeesData _employeesData;

        public HomeController(IEmployeesData employeesData)
        {
            _employeesData = employeesData;
        }

        public IActionResult Index()
        {
            //return Content("test");
            return View(_employeesData.GetAll());
        }

        public IActionResult Details(int id)
        {
            var employee= _employeesData.GetByID(id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }
    }
}