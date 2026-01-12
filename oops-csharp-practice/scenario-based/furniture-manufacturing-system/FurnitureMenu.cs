using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.furniture_manufacturing_system
{
    sealed class FurnitureMenu
    {
        private IFurnitureStrategy CarpenterService;
        private readonly int StockRodLength;
        private readonly int[] WoodPrices;
        public FurnitureMenu()
        {
            StockRodLength = 12;
            WoodPrices = new int[] { 2, 5, 8, 12, 14, 18, 22, 25, 30, 32, 35, 40 };
            CarpenterService = new FurnitureUtility();
        }
        public void BestCutToMaximizeEarning()
        {
            int earnings = CarpenterService.GetMaxRevenue(WoodPrices, StockRodLength);
            Console.WriteLine($"Optimal Earnings for {StockRodLength}ft rod: ${earnings}");
        }
        public void AddingFixedWaste()
        {
            Console.Write("Enter required cut size (ft): ");
            string input = Console.ReadLine();
            int size;

            if (int.TryParse(input, out size) && size > 0)
            {
                int waste;
                int revenue = CarpenterService.CalculateBatchRevenue(WoodPrices, StockRodLength, size, out waste);
                Console.WriteLine($"Cutting {StockRodLength}ft rod into {size}ft pieces:");
                Console.WriteLine($"Revenue: ${revenue}");
                Console.WriteLine($"Wood Wasted: {waste} ft");
            }
            else
            {
                Console.WriteLine("Invalid size input.");
            }
        }
        public void CutsSuggesting()
        {
            Console.WriteLine("Calculating best cut combination...");
            int[] suggestedCuts = CarpenterService.SuggestOptimalCuts(WoodPrices, StockRodLength);
            Console.Write("Recommended Cut Plan: ");
            for (int i = 0; i < suggestedCuts.Length; i++)
            {
                if (suggestedCuts[i] == 0)
                {
                    break;
                }
                Console.Write($"[{suggestedCuts[i]}ft] ");
            }
        }
    }
}
