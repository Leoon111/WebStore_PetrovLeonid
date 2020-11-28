using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore_PetrovLeonid.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("First controller action");
            return View();
        }

        public IActionResult SecondAction()
        {
            return Content("Second controller action");
        }
    }
}
