using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        //localhost/5001/home/index => home/index.cshtml
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewBag.Greeting = saat > 12 ? "İyi günler" : "Günaydın";
            ViewBag.UserName = "Uğur";


            return View();
        }
        //localhost/5001/home/about => home/abaout.cshtml
        public IActionResult About()
        {
            return View();
        }
    }
}
