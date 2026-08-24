using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FundooNotesApp.Models
{
    public class Reminder
    {
        [Key]
        public int ReminderId { get; set; }
        public int NoteId { get; set; }
        public int UserId { get; set; }
        [Required]
        public DateTime ReminderDate { get; set; }
        public bool IsProcessed { get; set; }
        [JsonIgnore]
        public virtual Notes Note { get; set; }
    }
}

