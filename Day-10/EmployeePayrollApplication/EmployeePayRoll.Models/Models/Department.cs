using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeePayRoll.Models
{
    // Represents a department in the organization
    public class Department
    {
        // Department unique identifier (Primary Key)
        [Key]
        public int DepartmentId { get; set; }

        // Department name
        public string DepartmentName { get; set; }

        // Collection of employees in this department
        public ICollection<Employee> Employees { get; set; }
    }
}