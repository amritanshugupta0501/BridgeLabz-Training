using EmployeePayRoll.Models;

namespace EmployeePayRoll.Repository
{
    // Department repository for database operations on departments
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        // Constructor to initialize the context
        public DepartmentRepository(EmployeePayRollDbContext context) : base(context)
        {
        }
    }
}