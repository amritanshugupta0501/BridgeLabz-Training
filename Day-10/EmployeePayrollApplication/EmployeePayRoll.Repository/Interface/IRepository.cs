using System.Collections.Generic;

namespace EmployeePayRoll.Repository
{
    // Generic repository interface for data access operations
    public interface IRepository<T> where T : class
    {
        // Get all entities
        IEnumerable<T> GetAll();

        // Get entity by ID
        T? GetById(int id);

        // Add new entity
        T Add(T entity);
    }
}