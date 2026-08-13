using EmployeePayRoll.Models;
using EmployeePayRoll.Repository;

namespace EmployeePayRoll.Business
{
    // Employee service for employee business logic operations
    public class EmployeeService : Service<Employee>, IEmployeeService
    {
        // Constructor to initialize employee repository
        public EmployeeService(IEmployeeRepository repository) : base(repository)
        {
        }
    }
}