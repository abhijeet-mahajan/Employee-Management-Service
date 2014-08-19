using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeManagementService
{
    public class EmployeeManagementService : IRetrieveEmployeeDeatils, ICreateEmployeeDetails
    {
        static List<EmployeeDetails> EmployeeDetailsList = new List<EmployeeDetails>();

        public EmployeeDetails GetEmployeeDetails(string employeeId)
        {
            return EmployeeDetailsList.Find(employee => employee.Id == employeeId); 
        }

        public List<EmployeeDetails> GetAllEmployeeDetails()
        {
            return EmployeeDetailsList;
        }

        public List<EmployeeDetails> GetEmployeeDetailsByName(string name)
        {
            return EmployeeDetailsList.FindAll(employee => employee.Name == name);
        }

        public void AddEmployeeDetails(string employeeId, string name, string employeeEmailId)
        {
            if (EmployeeDetailsList.Exists(employee => employee.Id == employeeId))
                throw new FaultException(new FaultReason("Employee Id already exists"), new FaultCode("101"));
            else
            {
                EmployeeDetails employee = new EmployeeDetails();
                employee.Id = employeeId;
                employee.EmailId = employeeEmailId;
                employee.Name = name;
                EmployeeDetailsList.Add(employee);
            }
        }

        public void AddRemarkTOEmployee(string employeeId, string text)
        {
            if (EmployeeDetailsList.Exists(employee => employee.Id == employeeId))
            {
                Remark remark = new Remark();
                remark.DateTime = DateTime.UtcNow;
                remark.Text = text;
                EmployeeDetailsList.Find(employee => employee.Id == employeeId).EmployeeRemark.Add(remark);
            }
            else
                throw new FaultException(new FaultReason("Employee Not Found"), new FaultCode("102"));
        }

        public void RemoveEmployeeDetails(string employeeId)
        {
            if (EmployeeDetailsList.Exists(employee => employee.Id == employeeId))
                EmployeeDetailsList.Remove(EmployeeDetailsList.Find(employee => employee.Id == employeeId));
            else
                throw new FaultException(new FaultReason("Employee Not Found"), new FaultCode("102"));
        }
    }
}

