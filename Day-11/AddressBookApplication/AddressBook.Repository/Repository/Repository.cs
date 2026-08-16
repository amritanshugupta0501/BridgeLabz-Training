using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookApp.Repository
{
    /// <summary>
    /// Generic base repository class that provides common data access operations.
    /// Implements the Repository pattern for database interactions using Entity Framework Core.
    /// Handles CRUD operations (Create, Read) for any entity type.
    /// </summary>
    /// <typeparam name="T">The entity type that this repository manages. Must be a reference type.</typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AddressBookDbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(AddressBookDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}