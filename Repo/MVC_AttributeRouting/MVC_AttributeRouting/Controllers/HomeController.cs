using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_AttributeRouting.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is Home controller and Index action method";
        }

        [Route("Student")]
        public string GetStudent()
        {
            return "All student recoed are here";
        }

        //Parameter passing
        [Route("Student/{Id}")]
        public string GetStudent(int id)
        {
            return "Student with id ="+id;
        }

        //Option Parameter
        //[Route("Student/Name/{Name?}")]
        //public string GetStudent(string name)
        //{
        //    return "Student name is =" + name;
        //}

        //Default value Parameter
        [Route("Student/Name/{Name=Besant}")]
        public string GetStudents(string name)
        {
            return "Student name is =" + name;
        }
    }
}