using BridgeLabzTraining.polymorphismabstraction.EmployeeManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmployeeWage
{
    // Interface designed to for employee details
    internal interface IEmployeeDetails
    {
         string EmployeeName1 { get ; set ; }
         int EmployeeId1 { get ; set ; }
         double EmployeeSalary1 { get ; set ; }
         string EmployeeEmailAddress1 { get ; set ; }
         string EmployeeMobileNumber1 { get ; set ; }
         double EmployeeWorkingHour1 { get; set ; }
         string EmployeeType1 { get ; set ; }

        string? ToString();
    }
}
