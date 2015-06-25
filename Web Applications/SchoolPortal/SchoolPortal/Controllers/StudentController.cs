using System;
using System.Web.Mvc;
using SchoolPortal.Domain.Models;
using SchoolPortal.Domain.Repository;
using SchoolPortal.Infrastructure.Repository;

namespace SchoolPortal.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository _repo;

        public StudentController()
        {
            _repo = new StudentRepository();
        }

        //
        // GET: /Student/
        //[HttpPost]
        public ActionResult Student()
        {
            return View("AddStudent");
        }
        
        [HttpPost]
        public ActionResult AddStudent(Person person)
        {
            _repo.AddStudent(person);

            return View();
        }

        [HttpGet]
        public ActionResult GetAllStudents()
        {
            var students = _repo.GetAllStudents();

            return View(students);
        }
    }
}