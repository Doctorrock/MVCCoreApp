using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;
using MVCCoreApp.ViewModels;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MVCCoreAppContext _context;

        public HomeController(MVCCoreAppContext context)
        {
            _context = context;
        }

        public IActionResult Index(string name)
        {
            
            PersonViewModel viewModel = null;
            if (name != null)
            {

                var person = new Person
                {
                    Name = name,
                    CreationTime = DateTime.Now
                };

                _context.Add(person);
                _context.SaveChanges();
                viewModel = new PersonViewModel(person);
            }

            return View(viewModel);
        }
        public IActionResult About()
        {
            ViewData["Title"] = "Moja pierwsza strona azure";
            ViewData["Message"] = "Hej jest to moja pierwsza strona w Azure.";

            return View();
        }

        public IActionResult Burger()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
