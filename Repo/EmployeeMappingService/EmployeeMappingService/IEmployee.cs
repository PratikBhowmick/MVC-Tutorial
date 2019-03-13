using System.ServiceModel;


namespace EmployeeMappingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployee
    {

        [OperationContract]
        EmployeeInfo GetEmployee(int id);

        [OperationContract]
        bool AddEmployee(EmployeeInfo employee);
    }    
}
