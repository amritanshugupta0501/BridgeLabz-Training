using System.ComponentModel.DataAnnotations;

namespace EmployeePayRoll.Models
{
    // Represents an employee in the payroll system
    public class Employee
    {
        // Employee unique identifier (Primary Key)
        [Key]
        public int EmployeeId { get; set; }

        // Employee first name
        public string EmployeeFirstName { get; set; }

        // Employee last name
        public string EmployeeLastName { get; set; }

        // Employee email address
        public string EmployeeEmail { get; set; }

        // Foreign key to Department
        public int DepartmentId { get; set; }

        // Navigation property to the employee's department
        public Department Department { get; set; }

        // Navigation property to the employee's salary profile
        public SalaryProfile SalaryProfile { get; set; }
    }
}