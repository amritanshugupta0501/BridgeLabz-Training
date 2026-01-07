using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.EmployeeManagementSystem
{
    internal class FullTimeEmployee : Employee, IDepartment
    {
        string Department;
        public FullTimeEmployee(int employeeId, string employeeName, int employeeSalary) : base(employeeId, employeeName, employeeSalary)
        {
        }
        public override void CalculateSalary()
        {
            Console.WriteLine($"Salary of Full Time Employee : {EmployeeSalary}");
        }
        public void AssignDepartment(string department)
        {
            Department = department;
        }
        public string GetDepartmentDetails()
        {
            return Department;
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Department the employee is assigned to : "+GetDepartmentDetails());
        }
    }
}
