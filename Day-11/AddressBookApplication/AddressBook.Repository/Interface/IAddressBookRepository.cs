using AddressBookApp.Models;

namespace AddressBookApp.Repository
{
    /// <summary>
    /// Repository interface for AddressBook data access operations.
    /// Inherits from the generic IRepository interface to provide specific functionality for address books.
    /// </summary>
    public interface IAddressBookRepository : IRepository<AddressBook>
    {
    }
}