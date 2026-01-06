using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu appMenu = new Menu(10);                // Create the Menu object with a sanctuary capacity of 10 birds
            appMenu.Run();                              // Start the application
        }

    }
}
