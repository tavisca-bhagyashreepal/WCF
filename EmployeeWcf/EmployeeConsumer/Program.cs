using EmployeeConsumer.EmployeeService;
using EmployeeWcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeConsumer
{
    public class Program
    {
        static void Main(string[] args)
        {
            String employeeName = "";
            String employeeRemarks = "";
            int employeeId;
            DateTime dateTime = DateTime.Now;
            String continueChoice = "n";
            int choice = 0;
            var employeeObject = new EmployeeWcf.EmployeeService();

            do
            {
                Console.WriteLine("Enter Employee Details:");
                do
                {
                    Console.WriteLine("1.Employee Name");
                    Console.WriteLine("2.Remarks");
                    Console.WriteLine("3.Date Time");
                    Console.WriteLine("4.Exit");
                    Console.WriteLine("Enter your Choice:");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: employeeName = Console.ReadLine();
                            break;
                        case 2: employeeRemarks = Console.ReadLine();
                            break;
                        case 3: dateTime = Convert.ToDateTime(Console.ReadLine());
                            break;
                        case 4: break;
                        default: break;
                    }


                } while (choice != 4);
                employeeObject.CreateEmployee(employeeName, dateTime, employeeRemarks);
                Console.WriteLine("Do you want to continue y/n ");
                continueChoice = Console.ReadLine();
            } while (continueChoice == "y");


            Console.WriteLine("Retrieve Employee Details:");
            do
            {
                Console.WriteLine("1.By EmployeeName");
                Console.WriteLine("2.By EmployeeId");
                Console.WriteLine("3.All Employees");
                Console.WriteLine("4.ByRemarks");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter your Choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: employeeName = Console.ReadLine();
                        employeeObject.GetEmployeeDetails(employeeName);

                        break;
                    case 2: employeeId = Convert.ToInt32(Console.ReadLine());
                        employeeObject.GetEmployeeDetails(employeeId);
                        break;

                    case 3:
                        employeeObject.GetAllEmployees();
                        break;

                    case 4: employeeRemarks = Console.ReadLine();
                        employeeObject.GetEmployeeByRemarks(employeeRemarks);
                        break;
                    case 5: break;
                    default: break;
                }
            } while (choice != 5);

            Console.WriteLine("Add Employee Details:");
            do
            {
                Console.WriteLine("1.RemarkById");
                Console.WriteLine("2.Exit");
                Console.WriteLine("Enter your Choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: Console.WriteLine("Enter EmployeeId");
                        employeeId = Convert.ToInt32(Console.ReadLine());
                        employeeObject.AddRemarksById(employeeId);
                        break;
                    case 2: break;
                    default: break;
                }
            } while (choice != 2);
            Console.ReadKey();
        }

    }
}
