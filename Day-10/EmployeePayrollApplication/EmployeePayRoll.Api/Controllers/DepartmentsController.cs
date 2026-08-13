using EmployeePayRoll.Business;
using EmployeePayRoll.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeePayRoll.Api
{
    // API controller for department endpoints
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        // Department service for business logic
        private readonly IDepartmentService _departmentService;

        // Constructor with dependency injection
        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        // GET: api/departments - Get all departments
        [HttpGet]
        public ActionResult<IEnumerable<Department>> GetDepartments()
        {
            return Ok(_departmentService.GetAll());
        }

        // GET: api/departments/{id} - Get department by ID
        [HttpGet("{id}")]
        public ActionResult<Department> GetDepartment(int id)
        {
            var department = _departmentService.GetById(id);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }

        // POST: api/departments - Create new department
        [HttpPost]
        public ActionResult<Department> AddDepartment(Department department)
        {
            var createdDepartment = _departmentService.Create(department);
            return CreatedAtAction(nameof(GetDepartment), new { id = createdDepartment.DepartmentId }, createdDepartment);
        }
    }
}