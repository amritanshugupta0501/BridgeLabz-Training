using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.furniture_manufacturing_system
{
    internal class FurnitureMain
    {
        static void Main()
        {
            FurnitureMenu furnitureMenu = new FurnitureMenu();
            furnitureMenu.BestCutToMaximizeEarning();
            furnitureMenu.AddingFixedWaste();
            furnitureMenu.CutsSuggesting();

            Console.WriteLine("\nJob Complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
