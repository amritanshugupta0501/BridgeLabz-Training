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
    public class RemindersController : ControllerBase
    {
        private readonly IReminderService _reminderService;
        public RemindersController(IReminderService reminderService)
        {
            _reminderService = reminderService;
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

        [HttpPost("Note/{noteId}/Add")]
        public IActionResult AddReminder(int noteId, [FromBody]ReminderDTO reminderDTO)
        {
            int userId = GetUserIdFromToken();
            var result = _reminderService.AddReminder(noteId, reminderDTO, userId);
            return Ok(new { Success = true, Message = "Reminder added successfully", Data = result });
        }
        [HttpGet("Note/{noteId}")]
        public IActionResult GetRemindersForNote(int noteId)
        {
            int userId = GetUserIdFromToken();
            var result = _reminderService.GetRemindersByNoteId(noteId, userId);
            return Ok(new { Success = true, Message = "Reminder retrieved successfully", Data = result });
        }
        [HttpPut("Update/{reminderId}")]
        public IActionResult UpdateReminder(int reminderId, [FromBody]ReminderDTO reminderDTO)
        {
            int userId = GetUserIdFromToken();
            var result = _reminderService.UpdateReminder(reminderId, reminderDTO, userId);
            return Ok(new { Success = true, Message = "Reminder updated successfully", Data = result });
        }
        [HttpDelete("Delete/{reminderId}")]
        public IActionResult DeleteReminder(int reminderId)
        {
            int userId = GetUserIdFromToken();
            var result = _reminderService.DeleteReminder(reminderId, userId);
            return Ok(new { Success = true, Message = "Reminder deleted successfully", Data = result });
        }
    }
}