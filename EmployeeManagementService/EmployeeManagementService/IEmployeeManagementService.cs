using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeManagementService
{
    [ServiceContract]
    public interface IRetrieveEmployeeDeatils
    {
        [OperationContract]
        EmployeeDetails GetEmployeeDetails(string employeeId);

        [OperationContract]
        List<EmployeeDetails> GetAllEmployeeDetails();

        [OperationContract]
        List<EmployeeDetails> GetEmployeeDetailsByName(string name);
    }

    [ServiceContract]
    public interface ICreateEmployeeDetails
    {
        [OperationContract]
        void AddEmployeeDetails(string employeeId, string name,string employeeEmailId);

        [OperationContract]
        void RemoveEmployeeDetails(string employeeId);

        [OperationContract]
        void AddRemarkTOEmployee(string employeeId, string text);
    }


    [DataContract]
    public class EmployeeDetails
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string EmailId { get; set; }

        [DataMember]
        public List<Remark> EmployeeRemark = new List<Remark>();
    }

    [DataContract]
    public class Remark
    {
        [DataMember]
        public DateTime DateTime { get; set; }

        [DataMember]
        public string Text { get; set; }
    }
}
