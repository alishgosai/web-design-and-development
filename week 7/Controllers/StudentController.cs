using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week_7.Models;

namespace week_7.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> StudentList = new List<Student>
            {
                new Student() {StudentId = 1, StudentName = "Alish", StudentNationality = "Australian", StudentAge = 20},
                new Student() {StudentId = 2, StudentName = "Alishhh", StudentNationality = "Australian", StudentAge = 20},

            };

            return View(StudentList);
        }
    }
}