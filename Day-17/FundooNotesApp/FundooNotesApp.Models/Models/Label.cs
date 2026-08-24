using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FundooNotesApp.Models
{
    public class Label
    {
        [Key]
        public int LabelId { get; set; }
        [Required]
        public string LabelName { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public virtual ICollection<Notes> Notes { get; set; }
    }
}