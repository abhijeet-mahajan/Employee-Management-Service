using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.ServiceModel;
using System.Linq;
using System.ServiceModel.Channels;
using EMSFixtures.EmployeeManagementServiceReference;
using System.Collections.Generic;


namespace EMSFixtures
{
    [TestClass]
    public class EmployeeManagementServiceFixtures
    {
        CreateEmployeeDetailsClient creator = new CreateEmployeeDetailsClient("BasicHttpBinding_ICreateEmployeeDetails");
        RetrieveEmployeeDeatilsClient retriever = new RetrieveEmployeeDeatilsClient("BasicHttpBinding_IRetrieveEmployeeDeatils");

        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void AddEmptyEmployeeDetails()
        {
            creator.AddEmployeeDetails("","","");

            List<EmployeeDetails> employeeList = new List<EmployeeDetails>(retriever.GetAllEmployeeDetails());
            Assert.IsTrue(employeeList.Any());
        }

        [TestMethod]
        public void AddEmployeeDetails()
        {
            creator.AddEmployeeDetails("1", "Vijay", "a@abc.com");
            creator.AddEmployeeDetails("2", "Gambhir", "a@abc.com");
            creator.AddEmployeeDetails("3", "Virat", "a@abc.com");
            creator.AddEmployeeDetails("4", "Rahane", "a@abc.com");
            creator.AddEmployeeDetails("5", "Dhoni", "e@abc.com");

            List<EmployeeDetails> employeeList = new List<EmployeeDetails>(retriever.GetAllEmployeeDetails());
            Assert.IsTrue(employeeList.Exists(employee => employee.Id == "1"));
        }
        
        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void AddAgainEmployeeDetails()
        {
            creator.AddEmployeeDetails("11", "Ishant", "a@abc.com");
            creator.AddEmployeeDetails("11", "Doosra Ishant", "a@abc.com");
            List<EmployeeDetails> employeeList = new List<EmployeeDetails>(retriever.GetAllEmployeeDetails());
            Assert.IsTrue(employeeList.Exists(employee => employee.Name == "Doosra Ishant"));
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void RemoveNonExistingEmployeeDetails()
        {
            creator.RemoveEmployeeDetails("13");
        }

        [TestMethod]
        public void AddRemarkToEmployeeDetails()
        {
            creator.AddRemarkTOEmployee("1", "achcha he..bahut achcha he!!!");
            creator.AddRemarkTOEmployee("2", "Team Leader");
            creator.AddRemarkTOEmployee("3", "Ok Ok");
            creator.AddRemarkTOEmployee("4", "Average");
            creator.AddRemarkTOEmployee("5", "Above Average");

            Assert.IsTrue(retriever.GetEmployeeDetails("1").EmployeeRemark[0].Text == "achcha he..bahut achcha he!!!");
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void AddRemarkToNonExistingEmployeeDetails()
        {
            creator.AddRemarkTOEmployee("13", "achcha he..bahut achcha he!!!");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RetrieveNonExistingEmployeeDetails()
        {
            EmployeeDetails employee = retriever.GetEmployeeDetails("13");
            Assert.IsTrue(employee.Id == "13");
        }

        [TestMethod]
        public void RetrieveEmployeeDetails()
        {
            EmployeeDetails employee = retriever.GetEmployeeDetails("1");
            Assert.IsTrue(employee.Id == "1" && employee.Name == "Vijay");
        }

        [TestMethod]
        public void RetrieveEmployeeDetailsList()
        {
            List<EmployeeDetails> employeeList = new List<EmployeeDetails>(retriever.GetAllEmployeeDetails());
            Assert.IsTrue(employeeList.Exists(employee => employee.Id == "1"));
        }

        [TestMethod]
        public void RetrieveEmployeeByName()
        {
            List<EmployeeDetails> employeeList = new List<EmployeeDetails>(retriever.GetEmployeeDetailsByName("Virat"));
            Assert.IsTrue(employeeList.Exists(employee => employee.Name == "Virat"));
        }

        [TestMethod]
        public void RetrieveNonExistingEmployeeByName()
        {
            List<EmployeeDetails> employeeList = new List<EmployeeDetails>(retriever.GetEmployeeDetailsByName("Virat"));
            Assert.IsTrue(employeeList.Exists(employee => employee.Name == "Virat"));
        }

        [TestMethod]
        public void RemoveEmployeeDetails()
        {
            creator.RemoveEmployeeDetails("1");
            creator.RemoveEmployeeDetails("2");
            creator.RemoveEmployeeDetails("3");
            creator.RemoveEmployeeDetails("4");
            creator.RemoveEmployeeDetails("5");
            creator.RemoveEmployeeDetails("11");

            List<EmployeeDetails> employeeList = new List<EmployeeDetails>(retriever.GetAllEmployeeDetails());
            Assert.IsTrue(!employeeList.Exists(employee => employee.Id == "1"));
        }

    }
}

