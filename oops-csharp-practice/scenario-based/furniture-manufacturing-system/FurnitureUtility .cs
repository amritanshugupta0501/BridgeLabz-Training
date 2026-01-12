using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.furniture_manufacturing_system
{
    internal class FurnitureUtility : IFurnitureStrategy
    {
        public int GetMaxRevenue(int[] priceList, int rodLength)
        {
            int[] dpTable = new int[rodLength + 1];

            for (int i = 1; i <= rodLength; i++)
            {
                int maxVal = int.MinValue;
                for (int j = 0; j < i; j++)
                {
                    if (j < priceList.Length)
                        maxVal = Math.Max(maxVal, priceList[j] + dpTable[i - j - 1]);
                }
                dpTable[i] = maxVal;
            }
            return dpTable[rodLength];
        }
        public int CalculateBatchRevenue(int[] priceList, int rodLength, int fixedCutSize, out int wasteGenerated)
        {
            if (fixedCutSize <= 0 || fixedCutSize > rodLength)
            {
                wasteGenerated = rodLength;
                return 0;
            }
            int numberOfPieces = rodLength / fixedCutSize;
            wasteGenerated = rodLength % fixedCutSize;

            return numberOfPieces * priceList[fixedCutSize - 1];
        }
        public int[] SuggestOptimalCuts(int[] priceList, int rodLength)
        {
            int[] val = new int[rodLength + 1];
            int[] firstCut = new int[rodLength + 1];
            for (int i = 1; i <= rodLength; i++)
            {
                int maxVal = int.MinValue;
                for (int j = 0; j < i; j++)
                {
                    if (j < priceList.Length)
                    {
                        int currentVal = priceList[j] + val[i - j - 1];
                        if (currentVal > maxVal)
                        {
                            maxVal = currentVal;
                            firstCut[i] = j + 1;
                        }
                    }
                }
                val[i] = maxVal;
            }
            int[] resultCuts = new int[rodLength];
            int tempLength = rodLength;
            int count = 0;
            while (tempLength > 0)
            {
                int cutSize = firstCut[tempLength];
                resultCuts[count] = cutSize;
                tempLength -= cutSize;
                count++;
            }
            return resultCuts;
        }
    }
}
