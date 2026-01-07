using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmployeeWage
{
    // Blueprint of details of an employee
    internal class EmployeeImpl : IEmployeeDetails
    {
        private string EmployeeName;
        private int EmployeeId;
        private double EmployeeSalary;
        private string EmployeeEmailAddress;
        private string EmployeeMobileNumber;
        private double EmployeeWorkingHour;
        private string EmployeeType;
        private int EmployeeNumberOfDays;

        public string EmployeeName1 { get => EmployeeName; set => EmployeeName = value; }
        public int EmployeeId1 { get => EmployeeId; set => EmployeeId = value; }
        public string EmployeeEmailAddress1 { get => EmployeeEmailAddress; set => EmployeeEmailAddress = value; }
        public string EmployeeMobileNumber1 { get => EmployeeMobileNumber; set => EmployeeMobileNumber = value; }
        public double EmployeeWorkingHour1 { get => EmployeeWorkingHour; set => EmployeeWorkingHour = value; }
        public double EmployeeSalary1 { get => EmployeeSalary; set => EmployeeSalary = value; }
        public string EmployeeType1 { get => EmployeeType; set => EmployeeType = value; }
        public int EmployeeNumberOfDays1 { get => EmployeeNumberOfDays; set => EmployeeNumberOfDays = value; }

        public override string? ToString()
        {
            if (EmployeeType1.Equals("Part Time Employee"))
            {
                return $"Employee Name : {EmployeeName1}\nEmployee ID : {EmployeeId1}\nEmployee Salary : {EmployeeSalary1}\nEmployee Email Address : {EmployeeEmailAddress1}\nEmployee Contact Number : {EmployeeMobileNumber1}\nEmployee Type : {EmployeeType1}\nEmployee Working Days : {EmployeeNumberOfDays1}\nEmployee Total Working Hours : {EmployeeNumberOfDays1 * EmployeeWorkingHour1}";
            }
            return $"Employee Name : {EmployeeName1}\nEmployee ID : {EmployeeId1}\nEmployee Salary : {EmployeeSalary1}\nEmployee Email Address : {EmployeeEmailAddress1}\nEmployee Contact Number : {EmployeeMobileNumber1}\nEmployee Type : {EmployeeType1}";
        }
    }
}
