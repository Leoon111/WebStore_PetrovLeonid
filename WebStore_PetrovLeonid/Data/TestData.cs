using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore_PetrovLeonid.Models;

namespace WebStore_PetrovLeonid.Data
{
    public static class TestData
    {
        public static List<Employee> Employees { get; } = new()
        {
            new Employee() { Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 20 },
            new Employee() { Id = 1, LastName = "Петров", FirstName = "Петр", Patronymic = "Петрович", Age = 40 },
            new Employee() { Id = 1, LastName = "Михайлов", FirstName = "Михаил", Patronymic = "Михайлович", Age = 60 }
        };
    }
}
