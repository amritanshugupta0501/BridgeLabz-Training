using ContactsApp.Models;
using ContactsApp.Repository;
using System.Collections.Generic;

namespace ContactsApp.Business
{
    /// <summary>
    /// Implementation of the IContactServices interface.
    /// Provides business logic operations for managing contacts by delegating to the repository layer.
    /// </summary>
    public class ContactServicesImpl : IContactServices
    {
        private readonly IContactRepository _repository;

        public ContactServicesImpl(IContactRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ContactsModel> GetAllContacts()
        {
            return _repository.GetAllContacts();
        }
        public ContactsModel? GetContactById(int contactId)
        {
            return _repository.GetContactById(contactId);
        }
        public ContactsModel AddNewContact(ContactsModel contact)
        {
            return _repository.AddNewContact(contact);
        }
    }
}

