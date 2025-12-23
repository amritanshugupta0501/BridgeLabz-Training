using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Compute bonus of employees based on their years of service
   internal class BonusOfEmployees
    {
        static void Main()
        {
            double[,] employeeDetails = new double[2, 10];
            for (int outerLoop = 0; outerLoop < 10; outerLoop++)						// Input employee details from the user
            {
                Console.WriteLine("Give years of service and salary of employee " + (outerLoop + 1) + " : ");
                for (int innerLoop = 0; innerLoop < 2; innerLoop++)
                {
                    employeeDetails[innerLoop, outerLoop] = double.Parse(Console.ReadLine());
                }
            }
            double[] salary = new double[10];
            for (int outerloop = 0; outerloop < 10; outerloop++)						// Initiate a loop to compute bonus of the employees
            {
                if (employeeDetails[0, outerloop] > 5)
                {
                    salary[0] = employeeDetails[1, outerloop] * 0.05;
                }
                else
                {
                    salary[0] = employeeDetails[1, outerloop] * 0.02;
                }
            }
            for (int outerloop = 0; outerloop < 10; outerloop++)						// Displaying the  result
            {
                Console.WriteLine("Employee no. "+outerloop+" details :");
                Console.WriteLine("Old salary : " + employeeDetails[1, outerloop]);
                Console.WriteLine("Bonus Payment : " + salary[outerloop]);
                Console.WriteLine("New salary : "+(salary[outerloop]+ employeeDetails[1, outerloop]));
            }
        }
    }
