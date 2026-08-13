using EmployeePayRoll.Models;

namespace EmployeePayRoll.Repository
{
    // Salary profile repository for database operations on salary profiles
    public class SalaryProfileRepository : Repository<SalaryProfile>, ISalaryProfileRepository
    {
        // Constructor to initialize the context
        public SalaryProfileRepository(EmployeePayRollDbContext context) : base(context)
        {
        }
    }
}