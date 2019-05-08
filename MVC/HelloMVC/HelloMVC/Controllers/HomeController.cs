using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        // controllers have "action methods"
        // each action method is meant to handle a request to one path
        // it should return a view result to be rendered into HTML and sent as a HTTP response.

            // this index method handles requests to the following paths:
            // - /
            // - /home
            // - /Home/Index
        public IActionResult Index()
        {
            //so this means get the home/Index view and return it
            // home 


            return View();
        }

        public IActionResult Privacy()
        {
            //get the privacy view and return it
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
