using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EmployeePayRoll.Repository
{
    // Generic base repository class for common data access operations
    public class Repository<T> : IRepository<T> where T : class
    {
        // Database context instance
        protected readonly EmployeePayRollDbContext _context;

        // DbSet for the entity type T
        private readonly DbSet<T> _dbSet;

        // Constructor to initialize context and DbSet
        public Repository(EmployeePayRollDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        // Get all entities from database
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        // Get single entity by ID
        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        // Add new entity and save changes
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}