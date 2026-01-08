using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmployeeWage
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private Employee EmployeeDetail;
        // Code Snippet to add Employee Details
        public Employee AddEmployee()
        {
            EmployeeDetail = new Employee();
            Console.WriteLine("Give Employee Details :");
            Console.Write("Employee Name : ");
            EmployeeDetail.EmployeeName1 = Console.ReadLine();
            Console.Write("Employee Id : ");
            EmployeeDetail.EmployeeId1 = int.Parse(Console.ReadLine());
            Console.Write("Employee Email Address : ");
            EmployeeDetail.EmployeeEmailAddress1 = Console.ReadLine();
            Console.Write("Employee Contact Number : ");
            EmployeeDetail.EmployeeMobileNumber1 = Console.ReadLine();
            CheckEmployeeType(EmployeeDetail);
            return EmployeeDetail;
        }
        // Code Snippet to display employee details
        public void DisplayEmployeeDetails(Employee employee)
        {
            Console.WriteLine(employee.ToString());      
        }
        // Code Snippet to view the list of all employee's names
        public void ViewEmployeesList(Employee employee)
        {
            Console.WriteLine("Employee Name : "+employee.EmployeeName1);
        }
        // UC-1 Code Snippet to check attendance of the given employee
        public void CheckAttendance(Employee employee)
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
        public void CalculateDailyWage(Employee employee)
        {
            employee.EmployeeSalary1 = employee.EmployeeWorkingHour1 * employee.EmployeeNumberOfDays1 * 200;
        }
        // UC-3 Code Snippet to check and calculate the wage of a part time employee
        public void CheckEmployeeType(Employee employee)
        {
            Console.WriteLine("Is the Employee \n1. Full Time\n2. Part Time");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 2)
            {
                employee.EmployeeType1 = "Part Time Employee";
                Console.Write("Employee Working hours per day : ");
                employee.EmployeeWorkingHour1 = double.Parse(Console.ReadLine());
                CalculateWageForAMonth(employee);
                CalculateDailyWage(EmployeeDetail);              
            }
            else
            {
                employee.EmployeeType1 = "Full Time Employee";
                Console.WriteLine("Employee Salary : ");
                employee.EmployeeSalary1 = double.Parse(Console.ReadLine());
            }
        }
        // UC-5 Code Snippet to Calculate attendance for the whole month
        public void CalculateWageForAMonth(Employee employee)
        {
            employee.EmployeeNumberOfDays1 = 0;
            Random attendanceCheck = new Random();
            for (int loop = 1; loop <= 30; loop++)
            {               
                int attendance = attendanceCheck.Next(0, 2);
                if (attendance == 1)
                {
                    employee.EmployeeNumberOfDays1++;
                    if(CheckWorkingHoursOrDays(employee))
                    {
                        employee.EmployeeNumberOfDays1 -= 1;
                        return;
                    }
                }
            }
        }
        // UC-6 Code Snippet to check Working hours or days in the month 
        public bool CheckWorkingHoursOrDays(Employee employee)
        {
            if(employee.EmployeeNumberOfDays1 >= 20)
            {
                return true;
            }
            else if((employee.EmployeeNumberOfDays1 * employee.EmployeeWorkingHour1) > 100)
            {
                return true;
            }
            return false;
        }
    }
}
