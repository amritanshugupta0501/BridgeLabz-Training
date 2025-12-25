using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level3
{
    internal class CalendarDate
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());

            string monthName = GetMonthName(month);
            int daysInMonth = GetDaysInMonth(month, year);
            int startDay = GetStartDay(month, year);

            Console.WriteLine($"\n   {monthName} {year}");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            for (int i = 0; i < startDay; i++)
            {
                Console.Write("    ");
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write(day);

                if ((day + startDay) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            
        }

        static string GetMonthName(int month)
        {
            string[] months = {
                "", "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };
            return months[month];
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static int GetDaysInMonth(int month, int year)
        {
            int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month == 2 && IsLeapYear(year))
            {
                return 29;
            }
            return days[month];
        }

        static int GetStartDay(int m, int y)
        {
            int d = 1;
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;

            return d0;
        }
    }
}
