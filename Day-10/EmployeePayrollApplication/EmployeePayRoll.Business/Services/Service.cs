using EmployeePayRoll.Repository;
using System.Collections.Generic;

namespace EmployeePayRoll.Business
{
    // Generic base service class for business logic operations
    public class Service<T> : IService<T> where T : class
    {
        // Repository instance for data access
        protected readonly IRepository<T> _repository;

        // Constructor to initialize repository
        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        // Get all entities
        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        // Get entity by ID
        public T? GetById(int id)
        {
            return _repository.GetById(id);
        }

        // Create new entity
        public T Create(T entity)
        {
            return _repository.Add(entity);
        }
    }
}