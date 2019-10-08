using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimmPractice.Models.ViewModel
{
    public class Lesson7DayViewModel
    {
        public string EmployeeName { get; set; }
        public string Salary { get; set; }
        public string SalaryColor { get; set; }
        public string UserName { get; set; }
    }

    public class Lesson7DayListViewModel
    {
        public List<Lesson7DayViewModel> Employees { get; set; }
        public string UserName { get; set; }
    }


}