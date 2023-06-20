using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppHR.Entities
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public int DepartmentId { get; set; }
        public int WorkingDay { get; set; }
        public float RateSalary { get; set; }
        public Employee() { }

        public Employee(int empId, string fullName, DateTime dob, int departmentId, int workingDay, float rateSalary)
        {
            EmpId = empId;
            FullName = fullName;
            Dob = dob;
            DepartmentId = departmentId;
            WorkingDay = workingDay;
            RateSalary = rateSalary;
        }
    }
}
