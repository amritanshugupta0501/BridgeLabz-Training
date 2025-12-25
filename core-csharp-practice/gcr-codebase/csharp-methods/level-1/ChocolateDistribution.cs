using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class ChocolateDistribution
    {
        int[] DistributedChocolates(int chocolates, int children)
        {
            int[] result = new int[2];
            result[0] = chocolates / children;
            result[1] = chocolates % children;
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Give the number of chocolates and  children to distribute : ");
            int chocolatesNumber = int.Parse(Console.ReadLine());
            int childrenNumber = int.Parse(Console.ReadLine());
            ChocolateDistribution chocolateDistribution = new ChocolateDistribution();
            int[] result = chocolateDistribution.DistributedChocolates(chocolatesNumber, childrenNumber);
            Console.WriteLine("Number of chocolates distributed among each children : " + result[0]);
            Console.WriteLine("Number of remaining chocolates : " + result[1]);
        }
    }
}
