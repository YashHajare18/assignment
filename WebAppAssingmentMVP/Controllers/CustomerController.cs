using Microsoft.AspNetCore.Mvc;
using WebAppAssingment.Models;

namespace WebAppAssingment.Controllers
{
    public class CustomerController : Controller
    {
        Icustomer _custprt;
        public CustomerController(Icustomer customer)
        { 
            _custprt = customer;
        }
        public IActionResult Index()
        {
            var custlist= _custprt.GetAllEmployee();
            return View(custlist);
        }
    }
}
