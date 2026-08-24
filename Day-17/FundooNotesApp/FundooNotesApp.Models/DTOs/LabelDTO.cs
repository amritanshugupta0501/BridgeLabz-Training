using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.Models
{
    public class LabelDTO
    {
        [Required]
        public string LabelName { get; set; }
    }
}

