using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmployeeWage
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private IEmployeeDetails EmployeeDetail;
        // Code Snippet to add Employee Details
        public IEmployeeDetails AddEmployee()
        {
            EmployeeDetail = new EmployeeImpl();
            Console.WriteLine("Give Employee Details :");
            Console.Write("Employee Name : ");
            EmployeeDetail.EmployeeName1 = Console.ReadLine();
            Console.Write("Employee Id : ");
            EmployeeDetail.EmployeeId1 = int.Parse(Console.ReadLine());
            Console.Write("Employee Working Hours : ");
            EmployeeDetail.EmployeeWorkingHour1 = double.Parse(Console.ReadLine());
            Console.Write("Employee Email Address : ");
            EmployeeDetail.EmployeeEmailAddress1 = Console.ReadLine();
            Console.Write("Employee Contact Number : ");
            EmployeeDetail.EmployeeMobileNumber1 = Console.ReadLine();
            CalculateDailyWage(EmployeeDetail);
            return EmployeeDetail;
        }
        // Code Snippet to display employee details
        public void DisplayEmployeeDetails(IEmployeeDetails employee)
        {
            Console.WriteLine(employee.ToString());      
        }
        // Code Snippet to view the list of all employee's names
        public void ViewEmployeesList(IEmployeeDetails employee)
        {
            Console.WriteLine("Employee Name : "+employee.EmployeeName1);
        }
        // UC-1 Code Snippet to check attendance of the given employee
        public void CheckAttendance(IEmployeeDetails employee)
        {
            Random attendanceCheck = new Random();
            int attendance = attendanceCheck.Next(0, 2);
            if(attendance == 1)
            {
                Console.WriteLine($"{employee.EmployeeName1} is present and is working at their desk.");
            }
            else
            {
                Console.WriteLine($"{employee.EmployeeName1} is absent.");
            }
        }
        // UC-2 Code Snippet to calculate daily wage of the employee
        public void CalculateDailyWage(IEmployeeDetails employee)
        {
            employee.EmployeeSalary1 = employee.EmployeeWorkingHour1 * 200;
        }
    }
}
