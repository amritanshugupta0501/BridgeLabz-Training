using EmployeePayRoll.Models;
using EmployeePayRoll.Repository;

namespace EmployeePayRoll.Business
{
    // Department service for department business logic operations
    public class DepartmentService : Service<Department>, IDepartmentService
    {
        // Constructor to initialize department repository
        public DepartmentService(IDepartmentRepository repository) : base(repository)
        {
        }
    }
}