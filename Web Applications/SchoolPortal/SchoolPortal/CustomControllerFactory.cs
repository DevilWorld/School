using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using SchoolPortal.Domain.Interfaces.Repository;
using SchoolPortal.Controllers;
using SchoolPortal.Infrastructure.Repository;

namespace SchoolPortal
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (requestContext.RouteData.Values["Controller"].ToString() == "Student")
            {
                IStudentRepository studentRepository = new StudentRepository();
                var controller = new StudentController(studentRepository);

                return controller;
            }
            else //(requestContext.RouteData.Values["Controller"].ToString() == "Home")
            {
                IUserRepository userRepository = new UserRepository();
                var controller = new HomeController(userRepository);

                return controller;
            }            
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            var dispose = controller as IDisposable;
            if (dispose != null)
                dispose.Dispose();                
        }
    }
}