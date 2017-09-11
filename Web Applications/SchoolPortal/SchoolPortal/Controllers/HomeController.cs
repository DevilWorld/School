using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolPortal.Models;
using SchoolPortal.Domain.Interfaces.Repository;

namespace SchoolPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;

        public HomeController() { }
        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            return View();
        }

        [HttpGet]
        public JsonResult CheckUserName(string userId)
        {
            var userExists = _userRepository.IsUserExists(userId);

            return Json(userExists, JsonRequestBehavior.AllowGet);            
        }
    }
}