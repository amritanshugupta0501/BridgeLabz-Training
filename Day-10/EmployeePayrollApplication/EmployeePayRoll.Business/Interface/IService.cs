using System.Collections.Generic;

namespace EmployeePayRoll.Business
{
    // Generic service interface for business logic operations
    public interface IService<T> where T : class
    {
        // Get all entities
        IEnumerable<T> GetAll();

        // Get entity by ID
        T? GetById(int id);

        // Create new entity
        T Create(T entity);
    }
}