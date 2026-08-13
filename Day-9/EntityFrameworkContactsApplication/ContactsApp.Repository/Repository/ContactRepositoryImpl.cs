using ContactsApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ContactsApp.Repository
{
    /// <summary>
    /// Implementation of the IContactRepository interface.
    /// Provides data access operations for contacts using Entity Framework Core.
    /// Handles all database interactions for contact management.
    /// </summary>
    public class ContactReporistoryImpl : IContactRepository
    {
        private readonly ContactsDBContext _context;

        public ContactReporistoryImpl(ContactsDBContext context)
        {
            _context = context;
        }

        public IEnumerable<ContactsModel> GetAllContacts()
        {
            return _context.Contacts.ToList();
        }

        public ContactsModel? GetContactById(int contactId)
        {
            return _context.Contacts.Find(contactId);
        }

        public ContactsModel AddNewContact(ContactsModel contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return contact;
        }
    }
}

