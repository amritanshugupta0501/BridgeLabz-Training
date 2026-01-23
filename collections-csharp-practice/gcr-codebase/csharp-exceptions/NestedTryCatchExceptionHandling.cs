using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.exceptions
{
    // Class Defined to depict multiple try-catch blocks and nested try-catch blocks usage
    internal class NestedTryCatchExceptionHandling
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            try 
            {
                Console.WriteLine("Enter array index : ");
                int index = int.Parse(Console.ReadLine());
                int value = numbers[index];
                Console.WriteLine("Value at index "+index+" : "+value);
                try
                {
                    Console.WriteLine("Enter divisor : ");
                    int divisor = int.Parse(Console.ReadLine());
                    int result = value / divisor;
                    Console.WriteLine("Result of division : "+result);
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("A Number cannot be divided by zero.");
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Index entered by you is out of range ");
            }
        }
    }
}
