using EmployeePayRoll.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeePayRoll.Repository
{
    // Database context for the Employee Payroll application
    public class EmployeePayRollDbContext : DbContext
    {
        // Constructor accepts DbContext options
        public EmployeePayRollDbContext(DbContextOptions<EmployeePayRollDbContext> options) : base(options)
        {
        }

        // Departments table
        public DbSet<Department> Departments { get; set; }

        // Employees table
        public DbSet<Employee> Employees { get; set; }

        // Salary Profiles table
        public DbSet<SalaryProfile> SalaryProfiles { get; set; }
    }
}