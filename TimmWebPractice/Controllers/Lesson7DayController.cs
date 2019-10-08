using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimmPractice.Models.ViewModel;
using TimmPractice.Models.DataModel;

namespace TimmPractice.Controllers
{
    public class Lesson7DayController : Controller
    {
        // GET: Lesson7Day
        public ActionResult Lesson7DayList()
        {
            List<Lesson7DayViewModel> Models = new List<Lesson7DayViewModel>();
            Lesson7DayListViewModel ListModel = new Lesson7DayListViewModel();

            Lesson7DayData empBal = new Lesson7DayData();
            List<Lesson7DayData.Employee> employees = empBal.GetEmployees();
            foreach (Lesson7DayData.Employee i in employees)
            {
                Lesson7DayViewModel Model = new Lesson7DayViewModel();
                Model.EmployeeName = i.FirstName + i.LastName;
                Model.Salary = i.Salary.ToString("C");
                Models.Add(Model);

            }
            ListModel.Employees = Models;
            ListModel.UserName = "Admin";

            return View(ListModel);
        }
    }
}