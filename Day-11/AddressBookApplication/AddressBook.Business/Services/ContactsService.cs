using AddressBookApp.Models;
using AddressBookApp.Repository;

namespace AddressBookApp.Business
{
    /// <summary>
    /// Service class for managing Contacts business logic operations.
    /// Inherits from the generic Service base class and provides specific functionality for contact entities.
    /// </summary>
    public class ContactsService : Service<Contacts>, IContactsService
    {
        public ContactsService(IContactRepository repository) : base(repository)
        {
        }
    }
}