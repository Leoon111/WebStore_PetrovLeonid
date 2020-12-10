using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebStore_PetrovLeonid.Data;
using WebStore_PetrovLeonid.Models;

namespace WebStore_PetrovLeonid.Controllers
{
    //[Route("Users")]
    public class EmployeesController : Controller
    {
        private readonly List<Employee> _Employees;

        public EmployeesController() => _Employees = TestData.Employees;

        //[Route("All")]
        public IActionResult Index() => View(TestData.Employees);

        //[Route("Info({id})")]
        public IActionResult Details(int id)
        {
            var employee = _Employees.FirstOrDefault(e => e.Id == id);
            if(employee is not null)
                return View(employee);

            return NotFound();
        }
    }
}
