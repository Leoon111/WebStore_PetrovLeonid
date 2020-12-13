using System;
using Microsoft.AspNetCore.Mvc;
using WebStore_PetrovLeonid.Infrastructure.Interfaces;
using WebStore_PetrovLeonid.Models;
using WebStore_PetrovLeonid.ViewModels;

namespace WebStore_PetrovLeonid.Controllers
{
    //[Route("Users")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _employees;

        public EmployeesController(IEmployeesData employees) => _employees = employees;

        //[Route("All")]
        public IActionResult Index()
        {
            var employee = _employees.Get();
            return View(employee);
        }

        //[Route("Info({id})")]
        public IActionResult Details(int id)
        {
            var employee = _employees.Get(id);
            if(employee is not null)
                return View(employee);

            return NotFound();
        }

        #region Edit

        /// <summary>
        /// Возвращает модель для редактирования по id
        /// </summary>
        /// <param name="id">id сотрудника</param>
        /// <returns>модель сотрудника из базы</returns>
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id < 0)
                return BadRequest();

            var employee = _employees.Get(id);
            if (employee is null)
                return NotFound();

            return View(new EmployeesViewModel
            {
                Id = employee.Id,
                LastName = employee.LastName,
                FirstName = employee.FirstName,
                Patronymic = employee.Patronymic,
                Age = employee.Age,
            });
        }

        /// <summary>
        /// Редактирование сотрудника
        /// </summary>
        /// <param name="model">модель сотрудника, которую редактируем</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(EmployeesViewModel model)
        {
            if (model is null)
                throw new ArgumentNullException(nameof(model));

            var employee = new Employee
            {
                Id = model.Id,
                LastName = model.LastName,
                FirstName = model.FirstName,
                Patronymic = model.Patronymic,
                Age = model.Age,
            };
            
            _employees.Update(employee);

            return RedirectToAction("Index");
        }

        #endregion

        #region Delete

        /// <summary>
        /// Возвращает форму на удаление сотрудника
        /// </summary>
        /// <param name="id">id сотрудника, которого хотим удалить</param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest();

            var employee = _employees.Get(id);
            if (employee is null)
                return NotFound();

            return View(new EmployeesViewModel()
            {
                Id = employee.Id,
                LastName = employee.LastName,
                FirstName = employee.FirstName,
                Patronymic = employee.Patronymic,
                Age = employee.Age,
            });
        }

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="id">id сотрудника, которого удаляем</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _employees.Delete(id);
            return RedirectToAction("Index");
        }

        #endregion
    }
}
