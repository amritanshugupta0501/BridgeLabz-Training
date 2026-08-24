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
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;
        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
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
        public IActionResult CreateNote([FromBody] NotesDTO notesDTO)
        {
            int userId = GetUserIdFromToken();
            var result = _noteService.CreateNote(notesDTO, userId);
            return Ok(new { Success = true, Message = "Note Created Succesfully!", Data = result });
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllNotes()
        {
            int userId = GetUserIdFromToken();
            var result = _noteService.GetAllNotes(userId);
            return Ok(new { Success = true, Message = "Notes retrieved successfully!", Data = result });
        }
        [HttpGet("Get/{noteId}")]
        public IActionResult GetNoteById(int noteId)
        {
            int userId = GetUserIdFromToken();
            var result = _noteService.GetNotesById(noteId, userId);
            return Ok(new { Success = true, Message = "Note retrieved successfully!", Data = result });
        }

        [HttpPut("Update/{noteId}")]
        public IActionResult UpdateNote(int noteId, [FromBody]NotesDTO notesDTO)
        {
            int userId = GetUserIdFromToken();
            var result = _noteService.UpdateNotes(noteId, notesDTO, userId);
            return Ok(new { Success = true, Message = "Note Updated Successfully!", Data = result });
        }
        [HttpDelete("Delete/{noteId}")]
        public IActionResult DeleteNote(int noteId)
        {
            int userId = GetUserIdFromToken();
            _noteService.DeleteNote(noteId, userId);
            return Ok(new { Success = true, Message = "Note Deleted Successfullt" });
        }
        [HttpPost("{noteId}/AddLabel/{labelId}")]
        public IActionResult AddLabelToNote(int noteId, int labelId)
        {
            int userId = GetUserIdFromToken();
            _noteService.AddLabelToNote(noteId, labelId, userId);
            
            return Ok(new { Success = true, Message = "Label attached to note successfully" });
        }

        [HttpDelete("{noteId}/RemoveLabel/{labelId}")]
        public IActionResult DeleteLabelFromNote(int noteId, int labelId)
        {
            int userId = GetUserIdFromToken();
            _noteService.DeleteLabelFromNote(noteId, labelId, userId);
            
            return Ok(new { Success = true, Message = "Label removed from note successfully" });
        }
    }
}

