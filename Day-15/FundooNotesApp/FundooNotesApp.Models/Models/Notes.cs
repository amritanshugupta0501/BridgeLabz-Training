using System;
using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.Models
{
    public class Notes
    {
        [Key]
        public int NoteId { get; set; }
        public int UserId { get; set; }
        public string NoteTitle { get; set; }
        public string Description { get; set; }
        public bool Pin { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Edited { get; set; }
        public bool Trash { get; set; } = false;
    }
}