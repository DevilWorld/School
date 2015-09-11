using System;
using System.Web.Mvc;
using SchoolPortal.Domain.Models;
using SchoolPortal.Domain.Repository;
using SchoolPortal.Infrastructure.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SchoolPortal.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository _repo;

        public StudentController()
        {
            _repo = new StudentRepository();
        }

        public ActionResult GetAllStudents()
        {
            return View();
        }

        //
        // GET: /Student/
        //[HttpPost]
        [HttpGet]
        public ActionResult AddStudent()
        {
            Person person = new Person();

            //pass the empty model to the view in the get method, WHEN THE REQUEST IS THROUGH THE URL. 
            //Only when the request via submit button, then we need to call the post method with parameters
            return View(person);
        }
        
        [HttpPost]
        public ActionResult AddStudent(Person person)
        {
            _repo.AddStudent(person);

            return View("GetAllStudents");
        }

        [HttpGet]
        public ActionResult GetStudentDetails()
        {
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
                        
            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(_repo.GetAllStudents(), settings),
                ContentType = "application/json"
            };
            
            return jsonResult;
        }
    }
}