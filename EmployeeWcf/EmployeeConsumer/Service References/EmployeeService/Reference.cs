﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeConsumer.EmployeeService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IEmployeeAddandCreate")]
    public interface IEmployeeAddandCreate {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeAddandCreate/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeAddandCreate/CreateEmployeeResponse")]
        void CreateEmployee(string Name, System.DateTime date, string remark);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeAddandCreate/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeAddandCreate/CreateEmployeeResponse")]
        System.Threading.Tasks.Task CreateEmployeeAsync(string Name, System.DateTime date, string remark);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeAddandCreate/AddRemarksById", ReplyAction="http://tempuri.org/IEmployeeAddandCreate/AddRemarksByIdResponse")]
        void AddRemarksById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeAddandCreate/AddRemarksById", ReplyAction="http://tempuri.org/IEmployeeAddandCreate/AddRemarksByIdResponse")]
        System.Threading.Tasks.Task AddRemarksByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeAddandCreateChannel : EmployeeConsumer.EmployeeService.IEmployeeAddandCreate, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeAddandCreateClient : System.ServiceModel.ClientBase<EmployeeConsumer.EmployeeService.IEmployeeAddandCreate>, EmployeeConsumer.EmployeeService.IEmployeeAddandCreate {
        
        public EmployeeAddandCreateClient() {
        }
        
        public EmployeeAddandCreateClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeAddandCreateClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeAddandCreateClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeAddandCreateClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CreateEmployee(string Name, System.DateTime date, string remark) {
            base.Channel.CreateEmployee(Name, date, remark);
        }
        
        public System.Threading.Tasks.Task CreateEmployeeAsync(string Name, System.DateTime date, string remark) {
            return base.Channel.CreateEmployeeAsync(Name, date, remark);
        }
        
        public void AddRemarksById(int id) {
            base.Channel.AddRemarksById(id);
        }
        
        public System.Threading.Tasks.Task AddRemarksByIdAsync(int id) {
            return base.Channel.AddRemarksByIdAsync(id);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IEmployeeRetrieve")]
    public interface IEmployeeRetrieve {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployees", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeesResponse")]
        void GetAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployees", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeesResponse")]
        System.Threading.Tasks.Task GetAllEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/SearchById", ReplyAction="http://tempuri.org/IEmployeeRetrieve/SearchByIdResponse")]
        void SearchById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/SearchById", ReplyAction="http://tempuri.org/IEmployeeRetrieve/SearchByIdResponse")]
        System.Threading.Tasks.Task SearchByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/SearchByName", ReplyAction="http://tempuri.org/IEmployeeRetrieve/SearchByNameResponse")]
        void SearchByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/SearchByName", ReplyAction="http://tempuri.org/IEmployeeRetrieve/SearchByNameResponse")]
        System.Threading.Tasks.Task SearchByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/SearchByRemark", ReplyAction="http://tempuri.org/IEmployeeRetrieve/SearchByRemarkResponse")]
        void SearchByRemark(string remark);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/SearchByRemark", ReplyAction="http://tempuri.org/IEmployeeRetrieve/SearchByRemarkResponse")]
        System.Threading.Tasks.Task SearchByRemarkAsync(string remark);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeRetrieveChannel : EmployeeConsumer.EmployeeService.IEmployeeRetrieve, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeRetrieveClient : System.ServiceModel.ClientBase<EmployeeConsumer.EmployeeService.IEmployeeRetrieve>, EmployeeConsumer.EmployeeService.IEmployeeRetrieve {
        
        public EmployeeRetrieveClient() {
        }
        
        public EmployeeRetrieveClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeRetrieveClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeRetrieveClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeRetrieveClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void GetAllEmployees() {
            base.Channel.GetAllEmployees();
        }
        
        public System.Threading.Tasks.Task GetAllEmployeesAsync() {
            return base.Channel.GetAllEmployeesAsync();
        }
        
        public void SearchById(int id) {
            base.Channel.SearchById(id);
        }
        
        public System.Threading.Tasks.Task SearchByIdAsync(int id) {
            return base.Channel.SearchByIdAsync(id);
        }
        
        public void SearchByName(string name) {
            base.Channel.SearchByName(name);
        }
        
        public System.Threading.Tasks.Task SearchByNameAsync(string name) {
            return base.Channel.SearchByNameAsync(name);
        }
        
        public void SearchByRemark(string remark) {
            base.Channel.SearchByRemark(remark);
        }
        
        public System.Threading.Tasks.Task SearchByRemarkAsync(string remark) {
            return base.Channel.SearchByRemarkAsync(remark);
        }
    }
}