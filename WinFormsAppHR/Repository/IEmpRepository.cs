using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppHR.Entities;

namespace WinFormsAppHR.Repository
{
    public interface IEmpRepository
    { 
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        void AddEmployee(Employee e);
        void UpdateEmployee(Employee e);
        void DeleteEmployee(Employee e);
    }
}
