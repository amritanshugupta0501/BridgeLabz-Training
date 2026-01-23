using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.exceptions
{
    // Class defined to handle the exception "DivideByZeroException" and usage of "finally" block
    internal class IntegerDivision
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a numerator : ");
                int numerator = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a denominator : ");
                int denominator = int.Parse(Console.ReadLine());
                int result = numerator / denominator;
                Console.WriteLine("Result of dvision of the two numbers : " + result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("A Number cannot be divided by zero.");
            }
            finally
            {
                Console.WriteLine("Operation Completed.");
            }
        }
    }
}
