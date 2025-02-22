using Microsoft.AspNetCore.Mvc;
using DEMOMVC.Models;  

namespace DEMOMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin chào " + ps.PersonId + " - " + ps.FullName + " - " + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
    }
}
