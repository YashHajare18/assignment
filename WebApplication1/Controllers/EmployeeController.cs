using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository _emprp;
        public EmployeeController(IEmployeeRepository emprp)
        {
            _emprp = emprp;
        }

        public IActionResult Index()
        {
            var emplist =_emprp.GetAllEmployee();
            return View(emplist);
        }
        public IActionResult Display()
        {
            return View();
        }
        
    }
}
