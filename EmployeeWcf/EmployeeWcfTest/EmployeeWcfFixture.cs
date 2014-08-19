using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeWcfTest.EmployeeService;
using System.Collections.Generic;
using System.Diagnostics;

namespace EmployeeWcfTest
{
    [TestClass]
    public class EmployeeWcfFixture
    {
        EmployeeAddandCreateClient _employeeAddandCreateClient = null; 
        EmployeeRetrieveClient _employeeRetrieveClient =null;
        Employee _employee = null;
        List<Employee> _employeeList = null;

        [TestInitialize]
        public void InitTestData()
        {
            _employeeAddandCreateClient = new EmployeeAddandCreateClient("WSHttpBinding_IEmployeeAddandCreate");
            _employeeRetrieveClient = new EmployeeRetrieveClient("BasicHttpBinding_IEmployeeRetrieve");
            _employee = new Employee();
            _employeeList = new List<Employee>();
         
        }

        [TestMethod]
        public void AddEmployeeTest()
        {                 
            _employee.Name = "Bhagyashree";
            _employee.Id = 1;
            _employee.Text = "Good Girl";
            _employee.Date = Convert.ToDateTime("12 / 2 / 2014");
            _employeeList.AddRange(_employeeAddandCreateClient.CreateEmployee(_employee)); 
            Assert.AreEqual(_employeeList[0].Id, 1);
        }
    
        [TestMethod]
        public void RetrieveEmployeeByIdTest()
        {
            
            _employee.Name = "Bhagyashree";
            _employee.Id = 2;
            _employee.Text = "Good Girl";
            _employee.Date = Convert.ToDateTime("12 / 2 / 2014");
            _employeeList.AddRange(_employeeAddandCreateClient.CreateEmployee(_employee)); 
            Employee empSearch = _employeeRetrieveClient.SearchById(2);
            Assert.AreEqual(2, empSearch.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException<FaultExceptionContract>))]
        public void RetrieveEmployeeByIdButIdNotPresentTest()
        {
            _employee.Name = "Bhagyashree";
            _employee.Id = 3;
            _employee.Text = "Good Girl";
            _employee.Date = Convert.ToDateTime("12 / 2 / 2014");
            _employeeList.AddRange(_employeeAddandCreateClient.CreateEmployee(_employee)); 
            Employee empSearch = _employeeRetrieveClient.SearchById(13);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException<FaultExceptionContract>))]
        public void AddAgainEmployeeTest()
        {
            
            _employee.Name = "Bhagyashree";
            _employee.Id = 4;
            _employee.Text = "Good Girl";
            _employee.Date = Convert.ToDateTime("12 / 2 / 2014");
            _employeeList.AddRange(_employeeAddandCreateClient.CreateEmployee(_employee)); 

            Employee employeeSecond = new Employee();
            employeeSecond.Name = "Deepali";
            employeeSecond.Id = 4;
            employeeSecond.Text = "Good Girl";
            employeeSecond.Date = Convert.ToDateTime("12 / 2 / 2014");
            _employeeList.AddRange(_employeeAddandCreateClient.CreateEmployee(employeeSecond));

        }

        [TestMethod]
        public void RetrieveEmployeeByNameTest()
        {
            _employee.Name = "Anuradha";
            _employee.Id = 5;
            _employee.Text = "Good Girl";
            _employee.Date = Convert.ToDateTime("12 / 2 / 2014");
            _employeeList.AddRange(_employeeAddandCreateClient.CreateEmployee(_employee));
            Employee employeeSearch = _employeeRetrieveClient.SearchByName("Anuradha");
            Assert.AreEqual("Anuradha",employeeSearch.Name );
        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException<FaultExceptionContract>))]
        public void RetrieveEmployeeByNameButNameNotPresentTest()
        {
            
            _employee.Name = "Bhagyashree";
            _employee.Id = 6;
            _employee.Text = "Good Girl";
            _employee.Date = Convert.ToDateTime("12 / 2 / 2014");
            _employeeList.AddRange(_employeeAddandCreateClient.CreateEmployee(_employee)); 
            Employee employeeSearch = _employeeRetrieveClient.SearchByName("Rashmi");
        }


        [TestMethod]
        public void RetrieveAllEmployeesTest()
        {
          
            _employee.Name = "Bhagyashree";
            _employee.Id = 7;
            _employee.Text = "Good Girl";
            _employee.Date = Convert.ToDateTime("12 / 2 / 2014");
            _employeeList.AddRange(_employeeAddandCreateClient.CreateEmployee(_employee)); 

            
            _employeeList.AddRange(_employeeRetrieveClient.GetAllEmployees());
            foreach (Employee empList in _employeeList)
            {
                Debug.WriteLine("EmployeeId:"+ empList.Id);
                Debug.WriteLine("EmployeeName:" + empList.Name);
                Debug.WriteLine("EmployeeRemark:" + empList.Text);
                Debug.WriteLine("EmployeeDate:" + empList.Date);
            }
           
        }

      


        [TestMethod]
        public void AddRemarkForExistingEmployeeTest()
        {
            _employee.Name = "Bhagyashree";
            _employee.Id = 8;
            _employee.Text = "Good Girl";
            _employee.Date = Convert.ToDateTime("12 / 2 / 2014");
            _employeeList.AddRange(_employeeAddandCreateClient.CreateEmployee(_employee)); 
            Employee employeeRemarkId =_employeeAddandCreateClient.AddRemarksById(8, "Bad Girl");
            Assert.AreEqual(employeeRemarkId.Text, "Bad Girl");           
        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException<FaultExceptionContract>))]
        public void AddRemarkForExistingEmployeeButEmployeeNotPresentTest()
        {
            
            _employee.Name = "Bhagyashree";
            _employee.Id = 9;
            _employee.Text = "Good Girl";
            _employee.Date = Convert.ToDateTime("12 / 2 / 2014");
            _employeeList.AddRange(_employeeAddandCreateClient.CreateEmployee(_employee)); 
            Employee employeeRemarkId = _employeeAddandCreateClient.AddRemarksById(12, "Bad Girl");    
        }


        [TestMethod]
        public void GetEmployeeByRemarkTest()
        {
            
            _employee.Name = "Bhagyashree";
            _employee.Id = 10;
            _employee.Text = "Good Girl";
            _employee.Date = Convert.ToDateTime("12 / 2 / 2014");
            _employeeList.AddRange(_employeeAddandCreateClient.CreateEmployee(_employee)); 
            _employeeList.AddRange(_employeeRetrieveClient.SearchByRemark("Good Girl"));
            Assert.AreEqual(_employeeList[0].Text, "Good Girl");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException<FaultExceptionContract>))]
        public void GetEmployeeByRemarkButRemarkNotPresentTest()
        {
           
            _employee.Name = "Bhagyashree";
            _employee.Id = 11;
            _employee.Text = "Good Girl";
            _employee.Date = Convert.ToDateTime("12 / 2 / 2014");
            _employeeList.AddRange(_employeeAddandCreateClient.CreateEmployee(_employee)); 
      
            _employeeList.AddRange(_employeeRetrieveClient.SearchByRemark(" Bad Boy"));
            
        }
    }
}
