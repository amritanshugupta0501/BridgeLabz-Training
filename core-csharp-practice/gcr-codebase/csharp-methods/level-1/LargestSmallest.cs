using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class LargestSmallest
    {
        int[] MaximumMinimum(int number1, int number2, int number3)
        {
            int[] result = new int[2];
            result[0] = number1 > number2 ? (number1 > number3 ? number1 : number3) : (number2 > number3 ? number2 : number3);
            result[1] = number1 < number2 ? (number1 < number3 ? number1 : number3) : (number2 < number3 ? number2 : number3);
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Give any three numbers : ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            LargestSmallest obj = new LargestSmallest();
            int[] result = obj.MaximumMinimum(number1, number2, number3);
            Console.WriteLine("Largest among the three numbers : " + result[0]);
            Console.WriteLine("Smallest among the three numbers : " + result[1]);
        }
    }
}
