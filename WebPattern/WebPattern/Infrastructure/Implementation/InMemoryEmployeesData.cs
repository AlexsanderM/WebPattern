using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPattern.Models;

namespace WebPattern.Infrastructure.Implementation
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<EmployeeView> _employees;

        public InMemoryEmployeesData()
        {
            _employees = new List<EmployeeView>()
            {
                new EmployeeView()
            {
                Id = 1,
                FirstName = "Vasia",
                Age = 22
            },
                new EmployeeView()
            {
                Id = 2,
                FirstName = "Ne Vasia",
                Age = 40
            }
            };
        }

        public IEnumerable<EmployeeView> GetAll()
        {
            return _employees;
        }

        public EmployeeView GetByID(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public void AddNew(EmployeeView model)
        {
            model.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(model);
        }

        public void Delete(int id)
        {
            var employee = GetByID(id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }

    }
}
