using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.metal_factory_pipe_cutting_system
{
    internal class RodCuttingMain
    {
        static void Main()
        {
            Console.WriteLine("Starting Rod Cutting Analysis Application...");
            RodCuttingMenu rodCuttingMenu = new RodCuttingMenu();
            rodCuttingMenu.SearchingForBestCuts();
            rodCuttingMenu.CheckImpact();
            rodCuttingMenu.CalculateRevenue();
            Console.WriteLine("\nExecution Complete. Press any key to exit.");
            Console.ReadKey();
        }
}
