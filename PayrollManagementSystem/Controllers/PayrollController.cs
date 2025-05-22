using Microsoft.AspNetCore.Mvc;
using PayrollManagementSystem.Models;

namespace PayrollManagementSystem.Controllers
{
    public class PayrollController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateSalary(BaseEmployee employee)
        {
            decimal salary = employee.CalculateSalary();
            ViewBag.Salary = salary;
            return View("Result");
        }
    }
}
