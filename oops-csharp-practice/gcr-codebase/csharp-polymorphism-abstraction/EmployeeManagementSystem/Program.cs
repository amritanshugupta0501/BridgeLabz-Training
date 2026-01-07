using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.EmployeeManagementSystem
{
    internal class Program
    {
        static int index;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Employees : ");
            int count = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[count];
            index = 0;
            while(true)
            {
                Console.WriteLine("Do you want to add employee ? Say yes or no.");
                string choice = Console.ReadLine();
                if (choice.ToLower().Equals("yes"))
                {
                    Console.WriteLine("Give Employee Details : ");
                    Console.Write("Employee Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Employee Id : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Is the employee \n1. Full Time\n2. Part Time...? Select an option.");
                    int employeeChoice = int.Parse(Console.ReadLine());
                    if (employeeChoice == 1)
                    {
                        Console.Write("Give the fixed Salary of the employee : ");
                        int salary = int.Parse(Console.ReadLine());
                        FullTimeEmployee employee1 = new FullTimeEmployee(id, name, salary);
                        employees[index] = employee1;
                        index++;
                    }
                    else if (employeeChoice == 2)
                    {
                        Console.Write("Give the Part Salary of the employee : ");
                        int salary = int.Parse(Console.ReadLine());
                        Console.Write("Give the Working hours of the employee : ");
                        double hours = double.Parse(Console.ReadLine());
                        PartTimeEmployee employee = new PartTimeEmployee(id, name, salary, hours);
                        employees[index] = employee;
                        index++;
                    }
                }
                else
                {
                    break;
                }
            }
            for (int loop = 0; loop < index; loop++)
            {
                employees[loop].DisplayDetails();
            }
        }
    }
}
