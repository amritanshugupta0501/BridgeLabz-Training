using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.metal_factory_pipe_cutting_system
{
    internal interface IRodCuttingStrategy
    {
        int GetMaxProfit(int[] priceList, int totalLength);
        int GetProfit(int[] priceList, int totalLength);
    }
}
