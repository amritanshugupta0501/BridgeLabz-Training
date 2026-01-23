using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.exceptions
{
    // Class defined to handle "DivideByZeroException" and "FormatException" exceptions during divison of numbers
    internal class NumberDivisionHandling
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
                Console.WriteLine("Result of dvision of the two numbers : "+result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divide a number by zero.");
            }
            catch(FormatException)
            {
                Console.WriteLine("Division is only possible with numbers.");
            }
        }
    }
}
