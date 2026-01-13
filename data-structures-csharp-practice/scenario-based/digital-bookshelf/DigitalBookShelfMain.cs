using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.digital_bookshelf
{
    // Entry point of the application
    internal class DigitalBookShelfMain
    {
        static void Main(string[] args)
        {
            DigitalBookShelfMenu digitalBookShelfMenu = new DigitalBookShelfMenu();
            digitalBookShelfMenu.HomeMenu();
        }
    }
}
