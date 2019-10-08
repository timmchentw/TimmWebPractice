using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimmPractice.Models.ViewModel;

namespace TimmPractice.Models.DataModel
{
    public class Lesson7DayData
    {
        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Salary { get; set; }
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "john";
            emp.LastName = "dear";
            emp.Salary = 14000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "michaek";
            emp.LastName = "jackson";
            emp.Salary = 16000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "robert";
            emp.LastName = "pat";
            emp.Salary = 20000;
            employees.Add(emp);

            return employees;
        }
    }
}