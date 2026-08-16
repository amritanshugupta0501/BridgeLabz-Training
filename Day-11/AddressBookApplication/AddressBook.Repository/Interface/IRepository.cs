using System.Collections.Generic;

namespace AddressBookApp.Repository
{
    /// <summary>
    /// Generic repository interface that defines the contract for data access operations.
    /// This interface establishes standard CRUD operations for all repository implementations.
    /// </summary>
    /// <typeparam name="T">The entity type that this repository manages. Must be a reference type.</typeparam>
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T entity);
    }
}