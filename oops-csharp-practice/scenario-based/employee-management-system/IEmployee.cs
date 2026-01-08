using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmployeeWage
{
    // Interface designed to prevent any data leak
    internal interface IEmployee
    {
        Employee AddEmployee();
        void DisplayEmployeeDetails(Employee employee);
        void ViewEmployeesList(Employee employee);
        void CheckAttendance(Employee employee);
        void CheckEmployeeType(Employee employee);
        void CalculateWageForAMonth(Employee employee);
        bool CheckWorkingHoursOrDays(Employee employee);
    }
}
