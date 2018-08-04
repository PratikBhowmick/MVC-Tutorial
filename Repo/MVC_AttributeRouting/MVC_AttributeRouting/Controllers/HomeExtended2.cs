using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_AttributeRouting.Controllers
{
    //Add this name infront of all action method
    [RoutePrefix("Employee")]
    ///Make a action method default (Example : http://localhost:53887/College/)
    [Route("{action=Index}")]
    public class HomeExtended2Controller : Controller
    {
        // GET: HomeExtended
        public string Index()
        {
            return "This ia Index";
        }

        //http://localhost:53887/Employee/Student/22)
        [Route("Student/{Id:int}")]
        public string GetStudent(int id)
        {
            return "Student with id =" + id;
        }


        //http://localhost:53887/Employee/Student/4
        [Route("Student/{Id:int:min(2):max(10)}")]
        //public string GetStudent(int id)
        //{
        //    return "Student with id =" + id;
        //}

        //http://localhost:53887/Employee/Student/22
        [Route("Student/{Name}")]
        public string GetStudent(string name)
        {
            return "Student name is =" + name;
        }

    }
}
