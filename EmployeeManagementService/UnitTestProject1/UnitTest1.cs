using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.ServiceReference;
using System.Diagnostics;
using System.ServiceModel;
using System.Linq;
using System.ServiceModel.Channels;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        CreateEmployeeDetailsClient creator = new CreateEmployeeDetailsClient("BasicHttpBinding_ICreateEmployeeDetails");
        RetrieveEmployeeDeatilsClient retriever = new RetrieveEmployeeDeatilsClient("BasicHttpBinding_IRetrieveEmployeeDeatils");


        [TestMethod]
        public void RemoveEmployeeDetails()
        {
            try
            {
                creator.RemoveEmployeeDetails("1");
                creator.RemoveEmployeeDetails("2");
                creator.RemoveEmployeeDetails("3");
                creator.RemoveEmployeeDetails("4");
                creator.RemoveEmployeeDetails("5");
            }
            catch (FaultException e)
            {
                Debug.WriteLine(e.Code.Name + " exception handled : " + e.Reason);
            }
        }


        [TestMethod]
        public void AddEmployeeDetails()
        {
            try
            {
                creator.AddEmployeeDetails("1","Vijay" ,"a@abc.com");
                creator.AddEmployeeDetails("2", "Gambhir","a@abc.com");
                creator.AddEmployeeDetails("3","Virat" ,"a@abc.com");
                creator.AddEmployeeDetails("4","Rahane", "a@abc.com");
                creator.AddEmployeeDetails("5","Dhoni", "e@abc.com");
            }
            catch (FaultException e)
            {
                    Debug.WriteLine(e.Code.Name+" exception handled : " + e.Reason);
            }
        }



        [TestMethod]
        public void AddAgainEmployeeDetails()
        {
            try
            {
                creator.AddEmployeeDetails("11","Ishant" ,"a@abc.com");
                creator.AddEmployeeDetails("11","Doosra Ishant" ,"a@abc.com");
            }
            catch (FaultException e)
            {
                Debug.WriteLine(e.Code.Name + " exception handled : " + e.Reason);
            }
        }

        [TestMethod]
        public void RemoveNonExistingEmployeeDetails()
        {
            try
            {
                creator.RemoveEmployeeDetails("13");
            }
            catch (FaultException e)
            {
                Debug.WriteLine(e.Code.Name + " exception handled : " + e.Reason);
            }
        }

        [TestMethod]
        public void AddRemarkToEmployeeDetails()
        {
            try
            {
                creator.AddRemarkTOEmployee("1","achcha he..bahut achcha he!!!");
                creator.AddRemarkTOEmployee("2", "Team Leader");
                creator.AddRemarkTOEmployee("3", "Ok Ok");
                creator.AddRemarkTOEmployee("4", "Average");
                creator.AddRemarkTOEmployee("5", "Above Average");

            }
            catch (FaultException e)
            {
                    Debug.WriteLine(e.Code.Name+" exception handled : " + e.Reason);
            }
        }

        [TestMethod]
        public void AddRemarkToNonExistingEmployeeDetails()
        {
            try
            {
                creator.AddRemarkTOEmployee("13", "achcha he..bahut achcha he!!!");

            }
            catch (FaultException e)
            {
                Debug.WriteLine(e.Code.Name + " exception handled : " + e.Reason);
            }
        }


        [TestMethod]
        public void RetrieveNonExistingEmployeeDetails()
        {
            try
            {
                EmployeeDetails employee=retriever.GetEmployeeDetails("13");
                Debug.WriteLine("Id: " + employee.Id + "Name: " + employee.Name + "\nEmail Id: " + employee.EmailId);
                for (int i = 0; i < employee.EmployeeRemark.Length; i++)
                {
                    Debug.WriteLine(employee.EmployeeRemark[i].DateTime + "  " + employee.EmployeeRemark[i].Text);
                }
            }
            catch (FaultException e)
            {
                Debug.WriteLine(e.Code.Name + " exception handled : " + e.Reason);
            }
        }

        [TestMethod]
        public void RetrieveEmployeeDetails()
        {
            try
            {
                EmployeeDetails employee = retriever.GetEmployeeDetails("1");
                Debug.WriteLine("Id: " + employee.Id + "Name: " + employee.Name + "\nEmail Id: " + employee.EmailId);
                for (int i = 0; i < employee.EmployeeRemark.Length; i++)
                {
                    Debug.WriteLine(employee.EmployeeRemark[i].DateTime + "  " + employee.EmployeeRemark[i].Text);
                }
            }
            catch (FaultException e)
            {
                Debug.WriteLine(e.Code.Name + " exception handled : " + e.Reason);
            }
        }

        [TestMethod]
        public void RetrieveEmployeeDetailsList()
        {
            try
            {
                EmployeeDetails[] employeeList;
                employeeList = retriever.GetAllEmployeeDetails();

                for (int i = 0; i < employeeList.Length; i++)
                {
                    Debug.WriteLine("Employee Id: " + employeeList[i].Id + "Name: " + employeeList[i].Name + "  Employee Email Id: " + employeeList[i].EmailId);
                    for (int j = 0; j < employeeList[i].EmployeeRemark.Length; j++)
                    {
                        Debug.WriteLine(employeeList[i].EmployeeRemark[j].DateTime + "  " + employeeList[i].EmployeeRemark[j].Text);
                    }
                    Debug.WriteLine("");
                }

            }
            catch (FaultException e)
            {
                Debug.WriteLine(e.Code.Name + " exception handled : " + e.Reason);
            }
        }


        [TestMethod]
        public void RetrieveEmployeeByName()
        {
            try
            {
                EmployeeDetails[] employeeList;
                employeeList = retriever.GetEmployeeDetailsByName("Virat");

                for (int i = 0; i < employeeList.Length; i++)
                {
                    Debug.WriteLine("Employee Id: " + employeeList[i].Id + "Name: " + employeeList[i].Name + "  Employee Email Id: " + employeeList[i].EmailId);
                    for (int j = 0; j < employeeList[i].EmployeeRemark.Length; j++)
                    {
                        Debug.WriteLine(employeeList[i].EmployeeRemark[j].DateTime + "  " + employeeList[i].EmployeeRemark[j].Text);
                    }
                    Debug.WriteLine("");
                }

            }
            catch (FaultException e)
            {
                Debug.WriteLine(e.Code.Name + " exception handled : " + e.Reason);
            }
        }

        [TestMethod]
        public void RetrieveNonExistingEmployeeByName()
        {
            try
            {
                EmployeeDetails[] employeeList;
                employeeList = retriever.GetEmployeeDetailsByName("OneWhoShallNotBeNamed");

                for (int i = 0; i < employeeList.Length; i++)
                {
                    Debug.WriteLine("Employee Id: " + employeeList[i].Id + "Name: " + employeeList[i].Name + "  Employee Email Id: " + employeeList[i].EmailId);
                    for (int j = 0; j < employeeList[i].EmployeeRemark.Length; j++)
                    {
                        Debug.WriteLine(employeeList[i].EmployeeRemark[j].DateTime + "  " + employeeList[i].EmployeeRemark[j].Text);
                    }
                    Debug.WriteLine("");
                }

            }
            catch (FaultException e)
            {
                Debug.WriteLine(e.Code.Name + " exception handled : " + e.Reason);
            }
        }


    }
}
