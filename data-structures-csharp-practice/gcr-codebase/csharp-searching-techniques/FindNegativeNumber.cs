using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SearchingTechniques
{
    // Search for negative numbers in an array using linear search
    internal class FindNegativeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the length of the array : ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            Console.WriteLine("Add Numbers to the array : ");
            for (int loop = 0; loop < length; loop++)
            {
                numbers[loop] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative numbers in the array : ");
            for (int loop = 0; loop < length; loop++)
            {
                if (numbers[loop] < 0)
                {
                    Console.WriteLine(numbers[loop]);
                }
            }
        }
    }
}
