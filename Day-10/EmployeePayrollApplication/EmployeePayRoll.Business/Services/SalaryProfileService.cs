using EmployeePayRoll.Models;
using EmployeePayRoll.Repository;

namespace EmployeePayRoll.Business
{
    // Salary profile service for salary profile business logic operations
    public class SalaryProfileService : Service<SalaryProfile>, ISalaryProfileService
    {
        // Constructor to initialize salary profile repository
        public SalaryProfileService(ISalaryProfileRepository repository) : base(repository)
        {
        }
    }
}