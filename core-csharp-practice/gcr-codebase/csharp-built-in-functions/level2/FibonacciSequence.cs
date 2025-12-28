using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinfunction.level2
{
    internal class FibonacciSequence
    {
        static void Main()
        {
            Console.WriteLine("Give a range : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci Sequence with "+number+" elements : ");
            GenerateFibonacciSequence(number);
        }
        static void GenerateFibonacciSequence(int number)
        {
            int first = 0;
            int second = 1;
            int next;
            for(int loop = 0; loop < number; loop++)
            {
                Console.Write(first+", ");
                next = first + second;
                first = second;
                second = next;
            }
        }
    }
}
