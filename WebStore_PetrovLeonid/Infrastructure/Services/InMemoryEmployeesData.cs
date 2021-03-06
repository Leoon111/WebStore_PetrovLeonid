﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore_PetrovLeonid.Data;
using WebStore_PetrovLeonid.Infrastructure.Interfaces;
using WebStore_PetrovLeonid.Models;

namespace WebStore_PetrovLeonid.Infrastructure.Services
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<Employee> _employees = TestData.Employees;
        
        public IEnumerable<Employee> Get() => _employees;

        public Employee Get(int id) => _employees.FirstOrDefault(item => item.Id == id);

        public int Add(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(employee));

            if (_employees.Contains(employee))
                return employee.Id;

            employee.Id = _employees
                .Select(item => item.Id)
                .DefaultIfEmpty()
                .Max() + 1;
            
            _employees.Add(employee);
            return employee.Id;
        }

        public void Update(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(employee));

            if (_employees.Contains(employee))
                return;

            var db_item = Get(employee.Id);
            if(db_item is null) return;

            db_item.LastName = employee.LastName;
            db_item.FirstName = employee.FirstName;
            db_item.Patronymic = employee.Patronymic;
            db_item.Age = employee.Age;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            if (item is null) return false;
            return _employees.Remove(item);
        }
    }
}
