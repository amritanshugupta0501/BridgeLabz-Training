using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.employee-management-system
{
    // Sealed class to prevent inheritance of this class
    sealed class EmployeeMenu
    {
        private IEmployee EmployeeUtility;
        public int CountEmployees;
        // Code Snippet to display a menu for the user
        public void EmployeeChoices()
        {
            IEmployeeDetails[] employees = new IEmployeeDetails[100];
            CountEmployees = 0;
            EmployeeUtility = new EmployeeUtilityImpl();
            while(true)
            { 
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display Employee Details");
            Console.WriteLine("3. View All Employees");
            Console.WriteLine("4. Check Attendance");
            Console.WriteLine("5. Exit");
            int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        employees[CountEmployees] = EmployeeUtility.AddEmployee();
                        CountEmployees++;
                        break;
                    case 2:
                        Console.WriteLine("Select which employee detail you would like to see : ");
                        for (int loop = 0; loop < CountEmployees; loop++)
                        {
                            Console.Write($"{loop + 1}. ");
                            EmployeeUtility.ViewEmployeesList(employees[loop]);
                        }
                        int detailNumber = int.Parse(Console.ReadLine());
                        EmployeeUtility.DisplayEmployeeDetails(employees[detailNumber - 1]);
                        break;
                    case 3:
                        for (int loop = 0; loop < CountEmployees; loop++)
                        {
                            EmployeeUtility.ViewEmployeesList(employees[loop]);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Select which employee's attendance you would like to check : ");
                        for (int loop = 0; loop < CountEmployees; loop++)
                        {
                            Console.Write($"{loop + 1}. ");
                            EmployeeUtility.ViewEmployeesList(employees[loop]);
                        }
                        detailNumber = int.Parse(Console.ReadLine());
                        EmployeeUtility.CheckAttendance(employees[detailNumber - 1]);
                        break;
                    case 5:
                        Console.WriteLine("Thank you for your efforts!");
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
