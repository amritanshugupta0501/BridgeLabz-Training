using AddressBookApp.Repository;
using System.Collections.Generic;

namespace AddressBookApp.Business
{
    /// <summary>
    /// Generic base service class that provides common business logic operations.
    /// This class implements the repository pattern to interact with the data layer.
    /// Handles CRUD operations (Create, Read) for any entity type.
    /// </summary>
    /// <typeparam name="T">The entity type that this service manages. Must be a reference type.</typeparam>
    public class Service<T> : IService<T> where T : class
    {
        protected readonly IRepository<T> _repository;
        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }
        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }
        public T GetById(int id)
        {
            return _repository.GetById(id);
        }
        public T Add(T entity)
        {
            return _repository.Add(entity);
        }
    }
}