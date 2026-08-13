using ContactsApp.Models;

namespace ContactsApp.Business
{
    /// <summary>
    /// Interface that defines the business logic operations for managing contacts.
    /// Provides methods for retrieving and creating contacts through the business layer.
    /// </summary>
    public interface IContactServices
    {
        IEnumerable<ContactsModel> GetAllContacts();
        ContactsModel? GetContactById(int contactId);
        ContactsModel AddNewContact(ContactsModel contact);
    }
}