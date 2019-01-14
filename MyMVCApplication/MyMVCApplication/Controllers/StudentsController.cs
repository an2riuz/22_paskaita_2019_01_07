using MyMVCApplication.Models.Students;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {

            List<Student> data = new List<Student>()
            {
                new Student(){Id = 0, Name = "Petras", Score = 9.9f, City = "Vilnius"},
                new Student(){Id = 1, Name = "Jonas", Score = 7.9f, City = "Kelme"}
            };
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(new Student() { Name = "Test", Score = 1.2f, City="Siauliai"});
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            Debug.WriteLine(student);
            return RedirectToAction("Index");

        }
    }
}