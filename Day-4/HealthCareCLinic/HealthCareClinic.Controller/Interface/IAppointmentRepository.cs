using System.Collections.Generic;
namespace HealthCareClinic.Controller
{
    // Defines appointment-specific repository operations such as filtering and lookup.
    public interface IAppointmentRepository<T>
    {
        bool Add(T model);
        List<T> GetAllAppointments();
        List<T> GetAppointmentByFilter(int? patientId = null, int? doctorId = null, int? appointmentid = null);
        bool Update(T model);
        bool Delete(int id);
    }
}