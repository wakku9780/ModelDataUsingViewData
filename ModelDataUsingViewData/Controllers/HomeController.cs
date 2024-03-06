using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;
using System.Diagnostics;

namespace ModelDataUsingViewData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var myEmployees = new List<Employee>
            {
                new Employee{EmpId=101,EmpName="Yash",Designation="Owner",Salary=250000},
                new Employee{EmpId=102,EmpName="Waqar",Designation="Ceo",Salary=30000},
                new Employee{EmpId=103,EmpName="Abdul",Designation="CO-Ceo",Salary=200000},
                new Employee{EmpId=104,EmpName="Azeem",Designation="Founder",Salary=500000},
                new Employee{EmpId=105,EmpName="Hozaifa",Designation="CO-Founder",Salary=400000},
            };

            //ViewData["myEmployee"] = myEmployees;

            //ViewBag.myEmployee=myEmployees;
            TempData["myEmployee"] = myEmployees;



            //Employee emp = new Employee()
            //{
            //    EmpId = 101,
            //    EmpName = "Waqar",
            //    Designation = "Manager",
            //    Salary=2500


            //};
            //ViewData["myEmployee"] = emp;
            // ViewBag.myEmployee = emp;
            //TempData["myEmployee"] = emp;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
