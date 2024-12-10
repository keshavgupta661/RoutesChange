using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoutesChange.Models;
using System.Collections.Generic;

namespace RoutesChange.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //for attribute way
        // [Route("students")]
        public ActionResult GetAllStudents()
        {
            var students = Students();
            return View(students);
        }

        //for attribute way
        // [Route("students/{id}")]
        public ActionResult GetStudent(int id)
        {
            var student = Students().FirstOrDefault(x=> x.Id == id);
            return View(student);
        }

        //for attribute way
        // [Route("students/{id}/Address")]
        public ActionResult GetStudentAddress(int id)
        {
            var studentAddress = Students().Where(x=>x.Id == id).Select(x=> x.Address).FirstOrDefault();
            return View(studentAddress);
        }

        private List<Student> Students()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Keshav",
                    Class = "Developer",
                    Address = new Address()
                    {
                        Address1 = "This is 1st address",
                        City = "This is 1st city",
                        HomeNumber = "1234567"
                    }
                },
                new Student()
                {
                    Id = 2,
                    Name = "Test",
                    Class = "Tester",
                    Address = new Address()
                    {
                        Address1 = "This is 2nd address",
                        City = "This is 2nd city",
                        HomeNumber = "1234567"
                    }
                },
                new Student()
                {
                    Id = 3,
                    Name = "Design",
                    Class = "Desinger",
                    Address = new Address()
                    {
                        Address1 = "This is 3rd address",
                        City = "This is 3rd city",
                        HomeNumber = "1234567"
                    }
                },
                new Student()
                {
                    Id = 4,
                    Name = "Manager",
                    Class = "Senior",
                    Address = new Address()
                    {
                        Address1 = "This is 4th address",
                        City = "This is 4th city",
                        HomeNumber = "1234567"
                    }
                },
            };
        }
    }
}