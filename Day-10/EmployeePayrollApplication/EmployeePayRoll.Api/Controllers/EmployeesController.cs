using EmployeePayRoll.Business;
using EmployeePayRoll.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeePayRoll.Api
{
    // API controller for employee endpoints
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // Employee service for business logic
        private readonly IEmployeeService _employeeService;

        // Constructor with dependency injection
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/employees - Get all employees
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            return Ok(_employeeService.GetAll());
        }

        // GET: api/employees/{id} - Get employee by ID
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            var employee = _employeeService.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        // POST: api/employees - Create new employee
        [HttpPost]
        public ActionResult<Employee> AddEmployee(Employee employee)
        {
            var createdEmployee = _employeeService.Create(employee);
            return CreatedAtAction(nameof(createdEmployee), new { id = createdEmployee.EmployeeId }, createdEmployee);
        }
    }
}