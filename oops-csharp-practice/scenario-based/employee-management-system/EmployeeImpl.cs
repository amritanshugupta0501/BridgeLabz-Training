using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.employee-management-system
{
    // Blueprint of details of an employee
    internal class EmployeeImpl : IEmployeeDetails
    {
        private string EmployeeName;
        private int EmployeeId;
        private double EmployeeSalary;
        private string EmployeeEmailAddress;
        private string EmployeeMobileNumber;

        public string EmployeeName1 { get => EmployeeName; set => EmployeeName = value; }
        public int EmployeeId1 { get => EmployeeId; set => EmployeeId = value; }
        public double EmployeeSalary1 { get => EmployeeSalary; set => EmployeeSalary = value; }
        public string EmployeeEmailAddress1 { get => EmployeeEmailAddress; set => EmployeeEmailAddress = value; }
        public string EmployeeMobileNumber1 { get => EmployeeMobileNumber; set => EmployeeMobileNumber = value; }

        public override string? ToString()
        {
            return $"Employee Name : {EmployeeName1}\nEmployee ID : {EmployeeId1}\nEmployee Salary : {EmployeeSalary1}\nEmployee Email Address : {EmployeeEmailAddress1}\nEmployee Contact Number : {EmployeeMobileNumber1}";
        }
    }
}
