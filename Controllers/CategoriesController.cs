using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //In your controller, add a method called Details that accepts 1 string parameter.
        //This method sends back a string to the view using the ViewBag that says "You selected category: [paramater-value-here]"
        public IActionResult Details(string categories)
        {

            ViewBag.statement = "You selected category: " + categories;
            return View();
        }
    }
}