using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace AddressBookApp.Models
{
    /// <summary>
    /// Represents an address book entity that contains a collection of contacts.
    /// This is a core domain model that serves as a container for organizing and managing contacts.
    /// </summary>
    public class AddressBook
    {
        [Key]
        public int AddressBookId { get; set; }
        public string AddressBookName { get; set; }
        public string AddressBookDescription { get; set; }
        public ICollection<Contacts> Contacts { get; set; } = new List<Contacts>();
    }
}