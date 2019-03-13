using EmployeeMappingService.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeMappingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Employee" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Employee.svc or Employee.svc.cs at the Solution Explorer and start debugging.
    public class Employee : IEmployee
    {
        Data data = new Data(); 
        public EmployeeInfo GetEmployee(int id)
        {
            return data.GetEmployee(id);
        }

        public bool AddEmployee(EmployeeInfo employee)
        {
            return data.AddEmployee(employee);
        }
    }
}
