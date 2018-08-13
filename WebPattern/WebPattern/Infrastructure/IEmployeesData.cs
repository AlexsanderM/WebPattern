using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPattern.Models;

namespace WebPattern.Infrastructure
{
    public interface IEmployeesData
    {
        IEnumerable<EmployeeView> GetAll();

        EmployeeView GetByID(int id);

        void AddNew(EmployeeView model);

        void Delete(int id);
    }
}
