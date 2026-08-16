using AddressBookApp.Models;
using AddressBookApp.Repository;

namespace AddressBookApp.Models
{
    /// <summary>
    /// Repository interface for Contacts data access operations.
    /// Inherits from the generic IRepository interface to provide specific functionality for contacts.
    /// </summary>
    public interface IContactRepository : IRepository<Contacts>
    {
    }
}