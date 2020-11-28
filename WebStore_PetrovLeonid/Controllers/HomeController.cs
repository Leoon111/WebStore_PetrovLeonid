using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore_PetrovLeonid.Models;

namespace WebStore_PetrovLeonid.Controllers
{
    public class HomeController : Controller
    {
        public static readonly List<Employee> _Employees = new()
        {
            new Employee() {Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 20},
            new Employee() {Id = 1, LastName = "Петров", FirstName = "Петр", Patronymic = "Петрович", Age = 40},
            new Employee() {Id = 1, LastName = "Михайлов", FirstName = "Михаил", Patronymic = "Михайлович", Age = 60}
        };

        public IActionResult Index() => View();

        public IActionResult SecondAction()
        {
            return Content("Second controller action");
        }

        public IActionResult Employees()
        {
            return View(_Employees);
        }
    }
}
