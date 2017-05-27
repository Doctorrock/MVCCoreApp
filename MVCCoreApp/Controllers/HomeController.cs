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

        public IActionResult Index(string name)
        {
            Person person;
            PersonViewModel viewModel = null;
            if (name != null)
            {
                person = new Person
                {
                    Name = name
                };
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

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
