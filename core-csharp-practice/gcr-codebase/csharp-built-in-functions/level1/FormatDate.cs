using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinfunction.level1
{
    internal class FormatDate
    {
        static void Main()
        {
            DateTime currentDate = DateTime.Now;                        // Get the current date
            string format1 = currentDate.ToString("dd/MM/yyyy");        // Change the date in the format : "dd/MM/yyyy"
            Console.WriteLine("Date in format \"dd/MM/yyyy\" : " + format1);
            
            string format2 = currentDate.ToString("yyyy-MM-dd");        // Change the date in the format : "yyyy-MM-dd"
            Console.WriteLine("Date in format \"yyyy-MM-dd\" : "+format2);
            
            string format3 = currentDate.ToString("ddd, MMM dd, yyyy"); // Change the date in the format : "ddd, MMM dd, yyyy"
            Console.WriteLine("Date in format \"ddd, MMM dd, yyyy\" : " + format3);
        }
    }
}
