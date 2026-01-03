using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpkeywords
{
    internal class EmployeeManagementSystem
    {
        public static string companyName = "Technology Solutions";
        private static int totalEmployees = 0;
        public readonly int employeeId;
        public string employeeName;
        public string designation;
        public EmployeeManagementSystem(int employeeId, string employeeName,string designation)                 // Constructor defined to get attributes for the employee
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.designation = designation;
            totalEmployees++;
        }
        public static void DisplayTotalEmployees()                                                              // Display total number of employees in the company
        {
            Console.WriteLine("Total employees in the company : "+totalEmployees);
        }
        public void DisplayDetails()                                                                            // Display details of the employee
        {
            Console.WriteLine("Company Name : "+companyName);
            Console.WriteLine("Employee Name : "+employeeName);
            Console.WriteLine("Employee Id : "+employeeId);
            Console.WriteLine("Employee Designation : "+designation);
        }
    }
    class Program
    {
        static void Main()                                                                                      // Entry point of the application
        {
            Console.WriteLine("Give employee 1 details : ");
            Console.Write("Give employee Name : ");
            string name1 = Console.ReadLine();
            Console.Write("Give employee Id : ");
            int id1 = int.Parse(Console.ReadLine());
            Console.Write("Give employee Designation : ");
            string designation1 = Console.ReadLine();
            EmployeeManagementSystem employee1 = new EmployeeManagementSystem(id1, name1, designation1);        // Constructor called first time to create an instance
            Console.WriteLine("Give employee 2 details : ");
            Console.Write("Give employee Name : ");
            string name2 = Console.ReadLine();
            Console.Write("Give employee Id : ");
            int id2 = int.Parse(Console.ReadLine());
            Console.Write("Give employee Designation : ");
            string designation2 = Console.ReadLine();
            EmployeeManagementSystem employee2 = new EmployeeManagementSystem(id2, name2, designation2);        // Constructor called second time to create a second instance
            if(employee1 is EmployeeManagementSystem)                                                           // Checking the type of object using 'is' operator
            {
                employee1.DisplayDetails();
            }
            else
            {
                Console.WriteLine("Invalid object.");
            }
            EmployeeManagementSystem.DisplayTotalEmployees();
        }
    }
}
