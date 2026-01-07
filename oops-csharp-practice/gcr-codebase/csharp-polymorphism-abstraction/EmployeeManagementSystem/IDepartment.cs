using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.EmployeeManagementSystem
{
    internal interface IDepartment
    {
        void AssignDepartment(string department);
        string GetDepartmentDetails();
    }
}
