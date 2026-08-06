using System.Collections.Generic;
namespace HealthCareClinic.Controller
{
    // Defines the standard CRUD operations for clinic-related repositories.
    public interface IHealthCareClinicRepository<T>
    {
        bool Add(T model);
        List<T> GetAllData();
        T GetDataById(int id);
        bool Update(T model);
        bool Delete(int id);
    }
}