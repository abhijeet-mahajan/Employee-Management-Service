using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeManagementService
{
 //   [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    public class EmployeeManagementService : IRetrieveEmployeeDeatils, ICreateEmployeeDetails
    {
        static List<EmployeeDetails> EmployeeDetailsList = new List<EmployeeDetails>();


        public EmployeeDetails GetEmployeeDetails(string employeeId)
        {
            foreach (EmployeeDetails employee in EmployeeDetailsList)
            {
                if (employee.Id == employeeId)
                    return employee;
            }
            throw new FaultException(new FaultReason("Employee Not Found"), new FaultCode("102"));
        }

        public List<EmployeeDetails> GetAllEmployeeDetails()
        {
            return EmployeeDetailsList;
        }

        public List<EmployeeDetails> GetEmployeeDetailsByName(string name)
        {
            List<EmployeeDetails> employeeDetailsListByName = new List<EmployeeDetails>();
            foreach (EmployeeDetails employee in EmployeeDetailsList)
            {
                if (employee.Name == name)
                {
                    employeeDetailsListByName.Add(employee);
                }
            }
            if (employeeDetailsListByName.Any())
            {
                return employeeDetailsListByName;
            }
            throw new FaultException(new FaultReason("Employee Not Found"), new FaultCode("102"));
        }

        public void AddEmployeeDetails(string employeeId, string name, string employeeEmailId)
        {
            foreach (EmployeeDetails existingEmployee in EmployeeDetailsList)
            {
                if (existingEmployee.Id == employeeId)
                {
                    throw new FaultException(new FaultReason("Employee Id already exists"), new FaultCode("101"));
                }
            }

            EmployeeDetails employee = new EmployeeDetails();
            employee.Id = employeeId;
            employee.EmailId = employeeEmailId;
            employee.Name = name;
            EmployeeDetailsList.Add(employee);
        }

        public bool RemoveEmployeeDetails(string employeeId)
        {
            if (EmployeeDetailsList.Any())
            {
                foreach (EmployeeDetails employee in EmployeeDetailsList)
                {
                    if (employee.Id == employeeId)
                    {
                        EmployeeDetailsList.Remove(employee);
                        return true;
                    }
                }
            }
            throw new FaultException(new FaultReason("Employee Not Found"), new FaultCode("102"));
        }

        public bool AddRemarkTOEmployee(string employeeId, string text)
        {
            Remark remark = new Remark();
            remark.DateTime = DateTime.UtcNow;
            remark.Text = text;

            foreach (EmployeeDetails employee in EmployeeDetailsList)
            {
                if (employee.Id == employeeId)
                {
                    employee.EmployeeRemark.Add(remark);
                    return true;
                }
            }

            throw new FaultException(new FaultReason("Employee Not Found"), new FaultCode("102"));
        }
    }
}

