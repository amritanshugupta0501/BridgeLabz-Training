using ContactsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsApp.Repository
{
    /// <summary>
    /// Database context class that represents the database session.
    /// Provides access to the Contacts table and manages entity framework operations.
    /// </summary>
    public class ContactsDBContext : DbContext
    {
        public ContactsDBContext(DbContextOptions<ContactsDBContext> options) : base(options)
        {
        }

        public DbSet<ContactsModel> Contacts { get; set; }
    }
}