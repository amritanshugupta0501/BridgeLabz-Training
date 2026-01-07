using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.EmployeeManagementSystem
{
    internal abstract class Employee
    {
        protected int EmployeeId;
        protected string EmployeeName;
        protected int EmployeeSalary;
        protected Employee(int employeeId, string employeeName, int employeeSalary) 
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeSalary = employeeSalary;
        }
        abstract public void CalculateSalary();
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name : {EmployeeName}\nEmployeeID : {EmployeeId}");
        }

    }
}
