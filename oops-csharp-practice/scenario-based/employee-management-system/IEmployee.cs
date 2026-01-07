using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.employee-management-system
{
    // Interface designed to prevent any data leak
    internal interface IEmployee
    {
        IEmployeeDetails AddEmployee();
        void DisplayEmployeeDetails(IEmployeeDetails employee);
        void ViewEmployeesList(IEmployeeDetails employee);
        void CheckAttendance(IEmployeeDetails employee);
    }
}
