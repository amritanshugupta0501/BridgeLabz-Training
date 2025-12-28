using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinfunction.level1
{
    internal class ArithmeticDate
    {
        static void Main()
        {
            Console.WriteLine("Give a date in the format ->\"yyyy-MM-dd\" : ");                                                             // Input date from the user in the format "yyyy-MM-dd"
            string inputDate = Console.ReadLine();
            if(DateTime.TryParse(inputDate, out DateTime date))                                                                             //  Check and convert string type to DateTime type
            {
                Console.WriteLine("Original Date : "+date.ToShortDateString());
                DateTime futureDate = date.AddDays(7).AddMonths(1).AddYears(2);                                                             // Adding 7 days, 1 month and 2 years to the original date
                Console.WriteLine("After adding 7 days, 1 month, and 2 years to the original date : "+futureDate.ToShortDateString());       
                DateTime finalDate = futureDate.AddDays(-21);                                                                               // Subtracting 3 weeks from the date
                Console.WriteLine("After subtracting 3 weeks : "+finalDate.ToShortDateString());
            }
            else
            {
                Console.WriteLine("Invalid date format. Please use \"yyyy-MM-dd\" format.");
            }
        }
    }
}
