using System;
using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.Models
{
    public class ReminderDTO
    {
        [Required]
        public DateTime ReminderDate { get; set; }
    }
}

