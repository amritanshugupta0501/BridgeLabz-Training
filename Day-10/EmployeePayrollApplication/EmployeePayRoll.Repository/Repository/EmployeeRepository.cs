using EmployeePayRoll.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EmployeePayRoll.Repository
{
    // Employee repository with eager loading of related entities
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        // Constructor to initialize the context
        public EmployeeRepository(EmployeePayRollDbContext context) : base(context)
        {
        }

        // Override to include Department and SalaryProfile
        public new IEnumerable<Employee> GetAll()
        {
            return _context.Employees
                .Include(e => e.Department)
                .Include(e => e.SalaryProfile)
                .ToList();
        }

        // Override to include Department and SalaryProfile for single employee
        public new Employee? GetById(int id)
        {
            return _context.Employees
                .Include(e => e.Department)
                .Include(e => e.SalaryProfile)
                .FirstOrDefault(e => e.EmployeeId == id);
        }
    }
}