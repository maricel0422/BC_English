using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BC_English.Models;
using Newtonsoft.Json;
using System.Net;
using System.Collections;

namespace BC_English.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            var webClient = new WebClient();
            //string json = (new WebClient()).DownloadString("https://raw.githubusercontent.com/aspsnippets/test/master/Customers.json");
            var json = webClient.DownloadString("https://www2.bellevuecollege.edu/data/api/v1/courses/engl");
            var courses = JsonConvert.DeserializeObject<CoursesL>(json);
            //Sort the results so the list of courses is going to be displayed in alphabetical order
            courses.Courses.Sort();

            return View(courses);            
        }

            
        
        public IActionResult About()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
