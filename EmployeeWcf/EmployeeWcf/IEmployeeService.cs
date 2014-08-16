using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeWcf
{
    
    [ServiceContract]
    public interface IEmployeeAddandCreate
    {
        [OperationContract]
        void CreateEmployee(String Name,  DateTime date, String remark);

        [OperationContract]
        void AddRemarksById(int id);
     
    }


    [ServiceContract]
    public interface IEmployeeRetrieve
    {
        [OperationContract]
        void GetAllEmployees();

        [OperationContract(Name = "SearchById")]
        void GetEmployeeDetails(int id);

        [OperationContract(Name = "SearchByName")]
        void GetEmployeeDetails(string name);


        [OperationContract(Name = "SearchByRemark")]
        void GetEmployeeByRemarks(string remark);
        // TODO: Add your service operations here
    }


    [DataContract]
    public class Employee
    {
        [DataMember] //this proprty should be exposed
        public int Id ;

        [DataMember]
        public string Name { get; set; }

        [DataMember] //this proprty should be exposed
        public DateTime date { get; set; }

        [DataMember]
        public string text { get; set; }

    }
}
