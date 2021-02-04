using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class CourseController:Controller
    {
        

        //action method
        //localhost:5000/course/index => course/index.cshmtl
        public IActionResult Index()
        {
            return View();
        }

        // localhost:5000/course/apply
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        // localhost:5000/course/apply
        // Name=value&Email=value&Phone=value&Confirm=value
        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View(student);
            }
        }
        public IActionResult Details()
        {

            var course = new Course();
            course.Name = "Core Mvc Kursu";
            course.description = "Fena değil";
            course.isPublished = true;

            return View(course);
        }

        //localhost:5000/course/list => course/list.cshmtl
        public IActionResult List()
        {
            var students = Repository.Students.Where(i=> i.Confirm == true);
            return View(students);
        }

    }
}
 