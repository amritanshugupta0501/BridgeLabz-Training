using System.Collections.Generic;

namespace AddressBookApp.Business
{
    /// <summary>
    /// Generic service interface that defines common business logic operations.
    /// This interface establishes the contract for all service implementations.
    /// </summary>
    /// <typeparam name="T">The entity type that this service manages. Must be a reference type.</typeparam>
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T entity);
    }
}