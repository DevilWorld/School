using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolPortal.Domain.Interfaces.Repository;

namespace SchoolPortal.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController() { }

        public StudentController(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddStudent()
        {
            _studentRepository.GetAllStudents();            

            return View();
        }
    }
}