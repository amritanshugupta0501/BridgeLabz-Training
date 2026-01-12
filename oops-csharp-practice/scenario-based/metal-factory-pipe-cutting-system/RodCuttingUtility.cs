using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.metal_factory_pipe_cutting_system
{
    internal class RodCuttingUtility : IRodCuttingStrategy
    {
        public int GetMaxProfit(int[] priceList, int totalLength)
        {
            if (totalLength <= 0 || priceList.Length == 0)
            {
                return 0;
            }
            int[] dpTable = new int[totalLength + 1];
            dpTable[0] = 0;
            // Build the table of maximum profits
            for (int i = 1; i <= totalLength; i++)
            {
                int currentMax = int.MinValue;
                for (int j = 0; j < i; j++)
                {
                    // Check bounds to prevent index errors
                    if (j < priceList.Length)
                    {
                        currentMax = Math.Max(currentMax, priceList[j] + dpTable[i - j - 1]);
                    }
                }
                dpTable[i] = currentMax;
            }
            return dpTable[totalLength];
        }
        // Logic refactored to be more explicit about cutting into two halves
        public int GetProfit(int[] priceList, int totalLength)
        {
            int halfLength = totalLength / 2;
            int priceIndex = halfLength - 1;
            if (priceIndex >= 0 && priceIndex < priceList.Length)
            {
                return priceList[priceIndex] * 2;
            }
            return 0;
        }
    }
}
