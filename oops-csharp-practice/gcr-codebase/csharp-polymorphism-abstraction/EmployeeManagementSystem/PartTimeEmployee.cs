using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.EmployeeManagementSystem
{
    internal class PartTimeEmployee : Employee, IDepartment
    {
        double WorkingHours;
        string Department;
        public PartTimeEmployee(int employeeId, string employeeName, int employeeSalary, double workingHours) : base(employeeId, employeeName, employeeSalary)
        {
            WorkingHours = workingHours;
        }
        public override void CalculateSalary()
        {
            Console.WriteLine($"Salary of the part-time : {WorkingHours * EmployeeSalary}");
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
            Console.WriteLine("Department the employee is assigned to : " + GetDepartmentDetails());
        }
    }
}
