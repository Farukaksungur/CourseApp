using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CourseApp.Controllers
{
    public class Course : Controller
    {
        public IActionResult Index()
        {
            var course = new Course_models();
            course.Name = "Faruk";
            course.desc = "deneme";
            course.isPublish = true;
            return View(course);
        }

        public IActionResult Details()
        {

            return View();
        }
        [HttpGet]
        public IActionResult forms()
        {

            return View();
        } 
        [HttpPost]
        public IActionResult basvuru_kayit(Student student)
        {
            Repository.AddStudent(student);


           return View("Thanks",student);
        }

        public IActionResult Katilim()            
        {

            var students = Repository.Students.Where(i => i.Confirm == true);
            return View(students);
        }
    }
}
