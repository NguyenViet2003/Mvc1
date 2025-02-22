using Microsoft.AspNetCore.Mvc;

namespace DEMOMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Salary(int id)
        {
            ViewData["Id"] = id;
            return View();
        }
    }
}