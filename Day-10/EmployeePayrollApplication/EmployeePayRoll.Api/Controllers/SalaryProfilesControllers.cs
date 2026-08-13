using EmployeePayRoll.Business;
using EmployeePayRoll.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeePayRoll.Api
{
    // API controller for salary profile endpoints
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryProfilesController : ControllerBase
    {
        // Salary profile service for business logic
        private readonly ISalaryProfileService _salaryProfileService;

        // Constructor with dependency injection
        public SalaryProfilesController(ISalaryProfileService salaryProfileService)
        {
            _salaryProfileService = salaryProfileService;
        }

        // GET: api/salaryprofiles - Get all salary profiles
        [HttpGet]
        public ActionResult<IEnumerable<SalaryProfile>> GetSalaryProfiles()
        {
            return Ok(_salaryProfileService.GetAll());
        }

        // GET: api/salaryprofiles/{id} - Get salary profile by ID
        [HttpGet("{id}")]
        public ActionResult<SalaryProfile> GetSalaryProfile(int id)
        {
            var salaryProfile = _salaryProfileService.GetById(id);
            if (salaryProfile == null)
            {
                return NotFound();
            }
            return Ok(salaryProfile);
        }

        // POST: api/salaryprofiles - Create new salary profile
        [HttpPost]
        public ActionResult<SalaryProfile> AddSalaryProfile(SalaryProfile department)
        {
            var createdSalaryProfile = _salaryProfileService.Create(department);
            return CreatedAtAction(nameof(GetSalaryProfile), new { id = createdSalaryProfile.ProfileId}, createdSalaryProfile);
        }
    }
}