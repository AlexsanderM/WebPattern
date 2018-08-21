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
            var employee = _employeesData.GetByID(id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }

        [Route("edit/{id?}")]
        [HttpGet]
        public IActionResult Edit(int? id) {
            EmployeeView model;
            if (id.HasValue)
            {
                model = _employeesData.GetByID(id.Value);
                if (ReferenceEquals(model, null))
                {
                    return NotFound();
                }
            }
            else
            {
                model = new EmployeeView();
            }

            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(EmployeeView model)
        {
            if (model.Age < 18)
            {
                ModelState.AddModelError("Age", "error age");
            }

            if (!ModelState.IsValid)
                return View(model);

            if (model.Id > 0)
            {
                var dbItem = _employeesData.GetByID(model.Id);

                if (ReferenceEquals(dbItem, null))
                    return NotFound();

                dbItem.FirstName = model.FirstName;
                dbItem.Age = model.Age;
            }
            else
            {
                _employeesData.AddNew(model);
            }

            return RedirectToAction(nameof(Index));
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _employeesData.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}