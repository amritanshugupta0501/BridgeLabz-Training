using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class PositiveNegativeInteger
    {
        int DeterminePolarity(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else if (number > 0)
            {
                return 1; 
            }
            else
            {
                return -1;
            }
        }
        static void Main()
        {
            Console.WriteLine("Give a number : ");
            int number = int.Parse(Console.ReadLine());
            PositiveNegativeInteger obj = new PositiveNegativeInteger();
            int polarity = obj.DeterminePolarity(number);
            if (polarity == 0)
            {
                Console.WriteLine("The number"+number+" is Zero.");
            }
            else if (polarity == 1)
            {
                Console.WriteLine("The number " + number + " is a Positive Integer.");
            }
            else
            {
                Console.WriteLine("The number " + number + " is a Negative Integer.");
            }
        }
    }
}
