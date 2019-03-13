using System.Runtime.Serialization;
using System.ServiceModel;

namespace EmployeeMappingService
{
    [DataContract]
    public class EmployeeInfo
    {
        [DataMember]
        public int EmpNo { get; set; }
        [DataMember]
        public string EmpName { get; set; }
        [DataMember]
        public int Salary { get; set; }
        [DataMember]
        public string DeptName { get; set; }
        [DataMember]
        public string Designation { get; set; }
    }
}