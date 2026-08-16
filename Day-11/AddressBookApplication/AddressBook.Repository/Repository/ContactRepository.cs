using AddressBookApp.Models;

namespace AddressBookApp.Repository
{
    /// <summary>
    /// Repository class for Contacts data access operations.
    /// Inherits from the generic Repository base class and provides specialized data access for contacts.
    /// Uses the base repository functionality for standard CRUD operations.
    /// </summary>
    public class ContactRepository : Repository<Contacts>, IContactRepository
    {
        public ContactRepository(AddressBookDbContext context) : base(context)
        {
        }
    }
}