using AddressBookApp.Models;

namespace AddressBookApp.Business
{
    /// <summary>
    /// Service interface for managing AddressBook business operations.
    /// Inherits from the generic IService interface to provide specific functionality for address books.
    /// </summary>
    public interface IAddressBookService : IService<AddressBook>
    {
    }
}