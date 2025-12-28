using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinfunction.level1
{
    internal class CompareDates
    {
        static void Main()
        {
            Console.WriteLine("Give the first date in the format -> dd-MM-yyyy : ");                        // Input two dates from the user
            string date1 = Console.ReadLine();
            Console.WriteLine("Give the second date in the format -> dd-MM-yyyy : ");
            string date2 = Console.ReadLine();
            DateTime newDate1 = DateTime.ParseExact(date1,"dd-MM-yyyy",CultureInfo.InvariantCulture);       // Convert both the dates to DateTime type using ParseExact in the format "dd-MM-yyyy"
            DateTime newDate2 = DateTime.ParseExact(date2, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int result = newDate1.CompareTo(newDate2);                                                      // Compare the dates and display the result
            if (result == 0)
            {
                Console.WriteLine("Both the dates are equal.");
            }
            else if(result < 0)
            {
                Console.WriteLine("Date1 is earlier than Date2.");
            }
            else
            {
                Console.WriteLine("Date2 is earlier than Date1.");
            }
        }
    }
}
