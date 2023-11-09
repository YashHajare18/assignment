using Microsoft.AspNetCore.Mvc;
using Mvc_with__Entity.Models;

namespace Mvc_with__Entity.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository) 
        {
            _employeeRepository= employeeRepository;
        }
        public IActionResult Index()
        {
            var model =_employeeRepository.GetAllEmployee();
            return View(model);
        }
        public IActionResult Details(int id)
        {
            var model = _employeeRepository.GetEmployee( id);
            return View(model);
        }
        public IActionResult Create() 
        { 
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                var model = _employeeRepository.Add(employee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public IActionResult Delete(int id) 
        { 
            var model = _employeeRepository.GetEmployee(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id,IFormCollection collection)
        {
            try
            {
                var model= _employeeRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch 
            {
                return View();
            }

        }
        public ActionResult Edit(int id)
        {
            var model = _employeeRepository.GetEmployee(id);
            return View(model);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                var model = _employeeRepository.Update(emp);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
