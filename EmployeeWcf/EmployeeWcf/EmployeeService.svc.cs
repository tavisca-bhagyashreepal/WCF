using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
namespace EmployeeWcf
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
  //  [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    public class EmployeeService : IEmployeeAddandCreate, IEmployeeRetrieve
    {
        private List<Employee> _List = new List<Employee>();
        private static int count = 0;
     
        
        public void CreateEmployee(String name  ,DateTime date , String remarks)
        {
            count++;
            _List.Add(new Employee() { Id= count ,Name =name, date = date ,text = remarks});           
        }

        public void GetAllEmployees()
        {
            foreach(Employee employee in _List)
            {
                Console.WriteLine("EmployeeName:" + employee.Name);
                Console.WriteLine("EmployeeId:" + employee.Id);
                Console.WriteLine("EmployeeDate:" + employee.date);
                Console.WriteLine("EmployeeRemark:" + employee.text);
            }
        }

        public void GetEmployeeDetails(int id)
        {
            
            int index =_List.FindIndex(a=>a.Id==(id));
               if(index>=0){
                    Console.WriteLine("EmployeeName:" + _List[index].Name);
                    Console.WriteLine("EmployeeId:" + _List[index].Id);
                    Console.WriteLine("EmployeeDate:" + _List[index].date);
                    Console.WriteLine("EmployeeRemark:" + _List[index].text);
                    
                }
                else
                    Console.WriteLine("Employee Not Found");
           
        }

        public void GetEmployeeDetails(string name)
        {
           
                int index =_List.FindIndex(a=>a.Name==name);
                if(index>=0){
                    Console.WriteLine("EmployeeName:" + _List[index].Name);
                    Console.WriteLine("EmployeeId:" + _List[index].Id);
                    Console.WriteLine("EmployeeDate:" + _List[index].date);
                    Console.WriteLine("EmployeeRemark:" + _List[index].text);
                }             
                
                else
                    Console.WriteLine("Employee Not Found");
            
        }

        public void AddRemarksById(int id)
        {
            int index =_List.FindIndex(a=>a.Id==id);
               if(index>=0){
                
                    Console.WriteLine("Enter Remark:");
                    _List[index].text= Console.ReadLine();
                  
                }
                else
                    Console.WriteLine("Employee Not Found");
            
        }

        public void GetEmployeeByRemarks(string remark)
        {
            int index =_List.FindIndex(a=>a.text==remark);
                if (index>=0)
                {
                    Console.WriteLine("EmployeeName:" + _List[index].Name);
                    Console.WriteLine("EmployeeId:" + _List[index].Id);
                    Console.WriteLine("EmployeeDate:" + _List[index].date);
                    Console.WriteLine("EmployeeRemark:" + _List[index].text);
                    
                    
                }
                else
                    Console.WriteLine("Employee Not Found");
            
        }

    }
}
