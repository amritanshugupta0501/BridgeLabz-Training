using System.ComponentModel.DataAnnotations;

namespace AddressBookApp.Models
{
    /// <summary>
    /// Represents a contact entity within an address book.
    /// Each contact contains personal information such as name, email, and phone number,
    /// and is associated with a specific address book.
    /// </summary>
    public class Contacts
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
        public int AddressBookId { get; set; }
        public AddressBook AddressBook { get; set; }
    }
}