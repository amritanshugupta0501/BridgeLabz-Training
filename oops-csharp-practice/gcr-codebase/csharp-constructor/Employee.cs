using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructor
{
    internal class Employee
    {
        public int employeeId;
        protected string department;
        private int salary;
        public Employee(int  employeeId, string department)                                 // Constructor Defining to get employee attributes
        {
            this.employeeId = employeeId;
            this.department = department;
        }
        public void SetSalary(int salary)                                                   // Setter method for private attribute salary
        { 
            this.salary = salary;
        }
        public int GetSalary()                                                              // Getter method for private attribute salary
        {
            return this.salary;
        }
    }
    class Manager : Employee                                                                // Manager class inheriting Employee class
    {
        public Manager(int employeeId, string department) : base(employeeId, department)    // Defining Manager constructor
        {
        }
        public void DisplayDetails()                                                        // Function to display details of employee
        {
            Console.WriteLine("Employee Id : "+employeeId);
            Console.WriteLine("Employee Department : "+department);
            Console.WriteLine("Employee Salary : "+GetSalary());
        }
    }
    class Program
    {
        static void Main()                                                                  // Entry point of application
        {
            Console.Write("Give Employee Id : ");
            int employeeId = int.Parse(Console.ReadLine());
            Console.Write("Give Employee Department : ");
            string department = Console.ReadLine();
            Console.Write("Give Employee Salary : ");
            int salary = int.Parse(Console.ReadLine());
            Manager manage = new Manager(employeeId, department);                           // Constructor calling of Manager class
            manage.SetSalary(salary);
            manage.DisplayDetails();
        }
    }
}
