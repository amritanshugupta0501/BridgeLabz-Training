using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.metal_factory_pipe_cutting_system
{
    sealed class RodCuttingMenu
    {
        private IRodCuttingStrategy CuttingService;
        private readonly int RodTotalLength;
        private readonly int[] MarketPrices;

        public RodCuttingMenu()
        {
            RodTotalLength = 8;
            MarketPrices = new int[] { 1, 5, 8, 9, 10, 17, 17, 20 };
            CuttingService = new RodCuttingUtility();
        }
        public void SearchingForBestCuts()
        {
            Console.WriteLine("Scenario A: Calculate Maximum Possible Profit");
            int maxResult = CuttingService.GetMaxProfit(MarketPrices, RodTotalLength);
            Console.WriteLine($"Max Profit for length {RodTotalLength} is: {maxResult}");
        }
        public void CheckImpact()
        {
            Console.Write("\nScenario B - Enter number of segments to cut: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int segments) && segments > 0)
            {
                // Check if the rod can be divided equally
                bool isDivisible = (RodTotalLength % segments == 0);

                if (isDivisible)
                {
                    int lengthPerPiece = RodTotalLength / segments;
                    int pricePerPiece = MarketPrices[lengthPerPiece - 1];
                    int totalProfit = pricePerPiece * segments;
                    Console.WriteLine($"Profit for {segments} equal pieces: {totalProfit}");
                }
                else
                {
                    Console.WriteLine("Cannot divide rod equally into that many segments.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        public void CalculateRevenue()
        {
            Console.Write("\nScenario C - Enter split count: ");

            // Refactored to separate validation from calculation
            try
            {
                int splitCount = Convert.ToInt32(Console.ReadLine());

                // Validation logic separated for clarity
                if (splitCount > RodTotalLength)
                {
                    Console.WriteLine("Error: Cannot cut more pieces than total length.");
                    return;
                }

                if (RodTotalLength % splitCount != 0)
                {
                    Console.WriteLine("Error: Rod length is not divisible by this count.");
                    return;
                }

                // Calculation
                int pieceSize = RodTotalLength / splitCount;
                int calculatedProfit = MarketPrices[pieceSize - 1] * splitCount;

                Console.WriteLine($"Calculated Profit: {calculatedProfit}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format.");
            }
        }
    }
}
