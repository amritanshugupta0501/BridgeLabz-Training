using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class LeapYear
    {
        bool CheckLeapYear(int year)
        {
            if(year >= 1582 )
            {
                if(((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))))
                {
                    return true;
                }
                else
                {
                    return false; 
                }
            }
            else
            {
                return false; 
            }
        }
        static void Main()
        {
            Console.WriteLine("Give a year to check if it is Leap year : ");
            int year = int.Parse(Console.ReadLine());
            LeapYear leapYear = new LeapYear();
            bool result = leapYear.CheckLeapYear(year);
            Console.WriteLine("Is the year "+ year +" leap year or not ? "+result);
        }
    }
}
