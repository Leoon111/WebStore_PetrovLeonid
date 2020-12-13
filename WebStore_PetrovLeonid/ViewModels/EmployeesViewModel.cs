using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore_PetrovLeonid.ViewModels
{
    public class EmployeesViewModel
    {
        /// <summary>Номер</summary>
        public int Id { get; set; }
        /// <summary>Имя</summary>
        public string FirstName { get; set; }
        /// <summary>Фамилия</summary>
        public string LastName { get; set; }
        /// <summary>Отчество</summary>
        public string Patronymic { get; set; }
        /// <summary>Возраст</summary>
        public int Age { get; set; }

    }
}
