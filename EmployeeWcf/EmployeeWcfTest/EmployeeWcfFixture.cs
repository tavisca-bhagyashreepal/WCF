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
        EmployeeAddandCreateClient _employeeAddandCreateClient =  new EmployeeAddandCreateClient("WSHttpBinding_IEmployeeAddandCreate");
        EmployeeRetrieveClient _employeeRetrieveClient =new EmployeeRetrieveClient("BasicHttpBinding_IEmployeeRetrieve");
        
        [TestMethod]
        public void AddEmployeeTest()
        {       
            Employee employee = new Employee();
            employee.Name = "Bhagyashree";
            employee.Id = 1;
            employee.Text = "Good Girl";
            employee.Date = Convert.ToDateTime("12 / 2 / 2014");
            List<Employee> empList = new List<Employee>();
            empList.AddRange(_employeeAddandCreateClient.CreateEmployee(employee)); 
            Assert.AreEqual(empList[0].Id, 1);
        }
    
        [TestMethod]
        public void RetrieveEmployeeByIdTest()
        {

            Employee employee = _employeeRetrieveClient.SearchById(1);
            Assert.AreEqual(1, employee.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException<FaultExceptionContract>))]
        public void RetrieveEmployeeByIdButIdNotPresentTest()
        {
            Employee employee = _employeeRetrieveClient.SearchById(2);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException<FaultExceptionContract>))]
        public void AddAgainEmployeeTest()
        {

            Employee employee = new Employee();
            employee.Name = "Deepali";
            employee.Id = 1;
            employee.Text = "Good Girl";
            employee.Date = Convert.ToDateTime("12 / 2 / 2014");
            List<Employee> empList = new List<Employee>();
            empList.AddRange(_employeeAddandCreateClient.CreateEmployee(employee));

        }

        [TestMethod]
        public void RetrieveEmployeeByNameTest()
        {

            Employee employee = _employeeRetrieveClient.SearchByName("Bhagyashree");
            Assert.AreEqual("Bhagyashree",employee.Name );
        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException<FaultExceptionContract>))]
        public void RetrieveEmployeeByNameButNameNotPresentTest()
        {
            Employee employee = _employeeRetrieveClient.SearchByName("Rashmi");
        }


        [TestMethod]
        public void RetrieveAllEmployeesTest()
        {

            List<Employee> employeeList = new List<Employee>();
            employeeList.AddRange(_employeeRetrieveClient.GetAllEmployees());
            foreach (Employee employee in employeeList)
            {
                Debug.WriteLine("EmployeeId:"+ employee.Id);
                Debug.WriteLine("EmployeeName:" + employee.Name);
                Debug.WriteLine("EmployeeRemark:" + employee.Text);
                Debug.WriteLine("EmployeeDate:" + employee.Date);
            }
            Assert.AreEqual(1, employeeList.Count);
        }

      


        [TestMethod]
        public void AddRemarkForExistingEmployeeTest()
        {

            Employee employee =_employeeAddandCreateClient.AddRemarksById(1, "Bad Girl");
            Assert.AreEqual(employee.Text, "Bad Girl");           
        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException<FaultExceptionContract>))]
        public void AddRemarkForExistingEmployeeButEmployeeNotPresentTest()
        {
            Employee employee = _employeeAddandCreateClient.AddRemarksById(3, "Bad Girl");    
        }


        [TestMethod]
        public void GetEmployeeByRemarkTest()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.AddRange(_employeeRetrieveClient.SearchByRemark("Bad Girl"));
            Assert.AreEqual(employeeList[0].Text, "Bad Girl");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException<FaultExceptionContract>))]
        public void GetEmployeeByRemarkButRemarkNotPresentTest()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.AddRange(_employeeRetrieveClient.SearchByRemark(" Bad Boy"));
            
        }
    }
}
