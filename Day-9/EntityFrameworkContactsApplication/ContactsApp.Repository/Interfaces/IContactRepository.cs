using ContactsApp.Models;

namespace ContactsApp.Repository
{
    /// <summary>
    /// Interface that defines the data access operations for managing contacts.
    /// Provides methods for CRUD operations on the Contacts data source.
    /// </summary>
    public interface IContactRepository
    {
        IEnumerable<ContactsModel> GetAllContacts();
        ContactsModel? GetContactById(int contactId);
        ContactsModel AddNewContact(ContactsModel contact);
    }
}