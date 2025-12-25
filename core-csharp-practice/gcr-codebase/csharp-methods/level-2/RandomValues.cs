using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class RandomValues
    {
        int[] GenerateValues(int size)
        {
            Random rnd = new Random();
            int[] numbers = new int[size];
            for (int loop = 0; loop < size; loop++)
            {
                numbers[loop] = rnd.Next(1000,9999);
            }
            return numbers;
        }
        double CalculateAverage(int[] numbers)
        {
            double sum = 0;
            for (int loop = 0; loop < numbers.Length; loop++)
            {
                sum += numbers[loop];
            }
            double average = sum / numbers.Length;
            return average;
        }
        int[] MinimumMaximum(int[] numbers)
        {
            int[] result = new int[2];
            result[0] = 1000;
            result[1] = 9999;
            for(int loop = 0; loop < numbers.Length;loop++)
            {
                result[0]=Math.Max(result[0], numbers[loop]);
                result[1]=Math.Min(result[1], numbers[loop]);
            }
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Give the size of the array : ");
            int size = int.Parse(Console.ReadLine());
            RandomValues random = new RandomValues();
            int[] numbers = random.GenerateValues(size);
            double average = random.CalculateAverage(numbers);
            int[] result = random.MinimumMaximum(numbers);
            Console.WriteLine("Average of all the generated numbers : "+average);
            Console.WriteLine("Maximum of all the generated numbers : " + result[0]);
            Console.WriteLine("Minimum of all the generated numbers : "+result[1]);

        }
    }
}
