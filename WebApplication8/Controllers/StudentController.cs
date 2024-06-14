using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;
namespace WebApplication8.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
        {
            new Student() { StudentId = 1, StudentName = "Alish", StudentNationality = "Australian", StudentAge = 20},
            new Student() { StudentId = 2, StudentName = "Alish", StudentNationality = "Australian", StudentAge = 20}
        };
        // GET: Student
        public ActionResult Index()
        {
            return View(StudentList);
        }
    }
}