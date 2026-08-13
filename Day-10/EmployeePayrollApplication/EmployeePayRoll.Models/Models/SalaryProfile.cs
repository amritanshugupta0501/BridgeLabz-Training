using System.ComponentModel.DataAnnotations;

namespace EmployeePayRoll.Models
{
    // Stores salary and financial information for an employee
    public class SalaryProfile
    {
        // Salary profile unique identifier (Primary Key)
        [Key]
        public int ProfileId { get; set; }

        // Employee's basic salary amount
        public decimal BasicSalary { get; set; }

        // Bank account number for salary payments
        public string BackAccountNumber { get; set; }

        // Tax identification number
        public string TaxIdentificationNumber { get; set; }

        // Foreign key to Employee
        public int EmployeeId { get; set; }

        // Navigation property to the associated employee
        public Employee Employee { get; set; }
    }
}