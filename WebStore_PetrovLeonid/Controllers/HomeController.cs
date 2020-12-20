using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WebStore_PetrovLeonid.Data;
using WebStore_PetrovLeonid.Models;

namespace WebStore_PetrovLeonid.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration) => _configuration = configuration;

        public IActionResult Throw(string id) => throw new ApplicationException(id);
        
        public IActionResult SecondAction()
        {
            return Content("Second controller action");
        }

        public IActionResult Index() => View();
        public IActionResult Blogs() => View();
        public IActionResult BlogSingle() => View();
        public IActionResult Cart() => View();
        public IActionResult Checkout() => View();
        public IActionResult ContactUs() => View();
        public IActionResult Login() => View();
        public IActionResult ProductDetails() => View();
        public IActionResult Shop() => View();
    }
}
