using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinfunction.level1
{
    internal class TimeZoneDisplay
    {
        static void Main()
        {
            DateTime utcNow = DateTime.UtcNow;                                                                      // Get the current time and display in the format "yyyy-MM-dd HH:mm:ss""
            Console.WriteLine("Universal Time (UTC) : "+utcNow.ToString("yyyy-MM-dd HH:mm:ss"));
            try
            {
                TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");                    // Display the current time in Greenwich Mean Time Zone
                DateTime gmtTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, gmtZone);
                Console.WriteLine("GMT(Greenwich Mean Time) : "+gmtTime.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            catch(TimeZoneNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");                  // Display the cuurent time in India Standard Time Zone
                DateTime istTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, istZone);
                Console.WriteLine("GMT(Greenwich Mean Time) : " + istTime.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            catch (TimeZoneNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");                // Display the current time in Pacific Standard Time Zone
                DateTime pstTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, pstZone);
                Console.WriteLine("GMT(Greenwich Mean Time) : " + pstTime.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            catch (TimeZoneNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
