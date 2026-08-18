using FundooNotesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FundooNotesApp.Repository
{
    public class FundooNotesAppDbContext : DbContext
    {
        public FundooNotesAppDbContext(DbContextOptions<FundooNotesAppDbContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}