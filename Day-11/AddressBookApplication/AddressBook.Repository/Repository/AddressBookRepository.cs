using AddressBookApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBookApp.Repository
{
    /// <summary>
    /// Repository class for AddressBook data access operations.
    /// Inherits from the generic Repository base class and provides specialized data access for address books.
    /// Handles eager loading of related contacts using Entity Framework Core Include method.
    /// </summary>
    public class AddressBookRepository : Repository<AddressBook>, IAddressBookRepository
    {
        public AddressBookRepository(AddressBookDbContext context) : base(context)
        {
        }
        public IEnumerable<AddressBook> GetAll()
        {
            return _context.AddressBooks.Include(a => a.Contacts).ToList();
        }
        public AddressBook GetById(int id)
        {
            return _context.AddressBooks.Include(a => a.Contacts).FirstOrDefault(a => a.AddressBookId == id);
        }
    }
}