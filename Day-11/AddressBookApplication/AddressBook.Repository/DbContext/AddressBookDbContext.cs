using AddressBookApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBookApp.Repository
{
    /// <summary>
    /// Database context class for Entity Framework Core.
    /// Manages the connection to the database and provides DbSet properties for accessing database tables.
    /// Configures the AddressBook application's data model and database interactions.
    /// </summary>
    public class AddressBookDbContext : DbContext
    {
        public AddressBookDbContext(DbContextOptions<AddressBookDbContext> options) : base(options)
        {
        }
        public DbSet<AddressBook> AddressBooks { get; set; }
        public DbSet<Contacts> Contact { get; set; }
    } 
}