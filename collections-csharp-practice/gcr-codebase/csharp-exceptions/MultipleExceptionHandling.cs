using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.exceptions
{
    // Class defined to handle multiple exceptions at the same time
    internal class MultipleExceptionHandling
    {
        void GetNumbersIndexValue(int[]numbers , int index)
        {
            try
            {
                int value = numbers[index]; 
                Console.WriteLine("Value at index "+index+" : "+value);
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Error Occurred : Index Value exceeded array length.");
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Error Occurred : No Array initialized");
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            MultipleExceptionHandling exceptionHandling = new MultipleExceptionHandling();
            exceptionHandling.GetNumbersIndexValue(numbers, 20);
            int[] nullArrayNumbers = null;
            exceptionHandling.GetNumbersIndexValue(nullArrayNumbers, 0);

        }
    }
}
