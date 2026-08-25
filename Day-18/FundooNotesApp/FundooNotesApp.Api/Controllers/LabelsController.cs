using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System;
using FundooNotesApp.Business;
using FundooNotesApp.Models;

namespace FundooNotesApp.Api
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LabelsController : ControllerBase
    {
        private readonly ILabelService _iLabelService;

        public LabelsController(ILabelService labelService)
        {
            _iLabelService = labelService;
        }

        private int GetUserIdFromToken()
        {
            var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if(string.IsNullOrEmpty(userIdClaim))
            {
                throw new Exception("User Id is not found in the token");
            }

            return Convert.ToInt32(userIdClaim);
        }

        [HttpPost("Create")]
        public IActionResult CreateLabel([FromBody] LabelDTO labelDTO)
        {
            int userId = GetUserIdFromToken();
            var result = _iLabelService.CreateLabel(labelDTO, userId);
            return Ok(new { Success = true, Message = "Label created successfully.", Data = result });
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllLabels()
        {
            int userId = GetUserIdFromToken();
            var result = _iLabelService.GetLabelByUserId(userId);
            return Ok(new { Success = true, Message = "Labels retrieve successfully.", Data = result });
        }

        [HttpPut("Update/{labelId}")]
        public IActionResult UpdateLabel(int labelId, [FromBody] LabelDTO labelDTO)
        {
            int userId = GetUserIdFromToken();
            var result = _iLabelService.UpdateLabel(labelId, labelDTO, userId);
            return Ok(new { Success = true, Message = "Label updated successfully.", Data = result });
        }

        [HttpDelete("Delete/{labelId}")]
        public IActionResult DeleteLabel(int labelId)
        {
            int userId = GetUserIdFromToken();
            var result = _iLabelService.DeleteLabel(labelId, userId);
            return Ok(new { Success = true, Message = "Label deleted successfully.", Data = result });
        }
    }
}