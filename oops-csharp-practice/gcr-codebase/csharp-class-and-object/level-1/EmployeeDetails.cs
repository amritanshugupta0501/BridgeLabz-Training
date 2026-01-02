using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.classandobject
{
    internal class EmployeeDetails
    {
        int employeeId;
        string employeeName;
        int employeeSalary;
        public EmployeeDetails(int employeeId, string employeeName, int employeeSalary) // Constructor to define characteristics of employee
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.employeeSalary = employeeSalary;
        }
        public void DisplayDetails()                                                    // Method to display details of an employee
        {
            Console.WriteLine("Employee Details : ");
            Console.WriteLine("Employee Name : " + employeeName);
            Console.WriteLine("Employee Id : " + employeeId);
            Console.WriteLine("Employee Salary : " + employeeSalary);
        }
    }
    internal class Program                                                              // Program to initialize the application
    {
        static void Main()
        {
            Console.WriteLine("Give employee details : ");
            Console.Write("Employee Name : ");
            string employeeName = Console.ReadLine();
            Console.Write("Employee Id : ");
            int employeeId = int.Parse(Console.ReadLine());
            Console.Write("Employee Salary : ");
            int employeeSalary = int.Parse(Console.ReadLine());
            EmployeeDetails employee = new EmployeeDetails(employeeId, employeeName, employeeSalary);   // Constructor called
            employee.DisplayDetails();
        }
    }
}
