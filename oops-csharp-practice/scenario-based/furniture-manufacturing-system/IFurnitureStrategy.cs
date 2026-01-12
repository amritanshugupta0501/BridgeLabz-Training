using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.furniture_manufacturing_system
{
    internal interface IFurnitureStrategy
    {
        int GetMaxRevenue(int[] priceList, int rodLength);
        int CalculateBatchRevenue(int[] priceList, int rodLength, int fixedCutSize, out int wasteGenerated);
        int[] SuggestOptimalCuts(int[] priceList, int rodLength);
    }
}
