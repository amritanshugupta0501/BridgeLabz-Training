using AddressBookApp.Models;
using AddressBookApp.Repository;

namespace AddressBookApp.Business
{
    /// <summary>
    /// Service class for managing AddressBook business logic operations.
    /// Inherits from the generic Service base class and provides specific functionality for address book entities.
    /// </summary>
    public class AddressBookService : Service<AddressBook>, IAddressBookService
    {
        public AddressBookService(IAddressBookRepository repository) : base(repository)
        {
        }
    }
}