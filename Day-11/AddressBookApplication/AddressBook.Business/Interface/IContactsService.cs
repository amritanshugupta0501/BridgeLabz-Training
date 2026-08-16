using AddressBookApp.Models;

namespace AddressBookApp.Business
{
    /// <summary>
    /// Service interface for managing Contacts business operations.
    /// Inherits from the generic IService interface to provide specific functionality for contacts.
    /// </summary>
    public interface IContactsService : IService<Contacts>
    {
    }
}