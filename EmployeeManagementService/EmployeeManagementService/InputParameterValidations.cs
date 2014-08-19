using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace EmployeeManagementService
{
    public class InputParameterValidations : IParameterInspector
    {
        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {

        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            if (operationName == "AddEmployeeDetails")
            {
                string employeeId = inputs[0].ToString();
                if (string.IsNullOrWhiteSpace(employeeId))
                    throw new FaultException(new FaultReason("Employee Id must contain some value"), new FaultCode("101"));

                string name= inputs[1].ToString();
                if (string.IsNullOrWhiteSpace(name))
                    throw new FaultException(new FaultReason("Employee name must contain some value"), new FaultCode("101"));

                string employeeEmailId = inputs[2].ToString();
                if (string.IsNullOrWhiteSpace(employeeEmailId))
                    throw new FaultException(new FaultReason("Employee emailId must contain some value"), new FaultCode("101"));

            }

            if (operationName == "GetEmployeeDetails")
            {
                string employeeId = inputs[0].ToString();
                if (string.IsNullOrWhiteSpace(employeeId))
                    throw new FaultException(new FaultReason("Employee Id must contain some value"), new FaultCode("101"));

            }

            if (operationName == "GetEmployeeDetailsByName")
            {
                string employeeId = inputs[0].ToString();
                if (string.IsNullOrWhiteSpace(employeeId))
                    throw new FaultException(new FaultReason("Employee Id must contain some value"), new FaultCode("101"));
            }

            if (operationName == "AddRemarkTOEmployee")
            {
                string employeeId = inputs[0].ToString();
                if (string.IsNullOrWhiteSpace(employeeId))
                    throw new FaultException(new FaultReason("Employee Id must contain some value"), new FaultCode("101"));

                string remark = inputs[1].ToString();
                if (string.IsNullOrWhiteSpace(remark))
                    throw new FaultException(new FaultReason("Employee remark must contain some value"), new FaultCode("101"));
            }

            if (operationName == "RemoveEmployeeDetails")
            {
                string employeeId = inputs[0].ToString();
                if (string.IsNullOrWhiteSpace(employeeId))
                    throw new FaultException(new FaultReason("Employee Id must contain some value"), new FaultCode("101"));
            }
            return null;

        }
    }
}