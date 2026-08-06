namespace HealthCareClinic.Services
{
    // Defines the common service operations for managing clinic entities.
    public interface IHealthCareClinicServices
    {
        public void AddDetails();
        public void DisplayAll();
        public void DisplayById();
        public void UpdateDetails();
        public void DeleteData();
    }
}