using System.ComponentModel.DataAnnotations;

namespace ContactsApp.Models
{
    /// <summary>
    /// Represents a contact entity with personal information.
    /// This model is used throughout the application for storing and managing contact data.
    /// </summary>
    public class ContactsModel
    {
        [Key]
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
    }
}