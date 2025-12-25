using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class SpringSeason
    {
        bool CheckSpringSeason(int month, int day)
        {
            if (month == 3 && day >= 20)                            // Check if the date lies within March 20 to June 20
            {
                return true;
            }
            else if (month == 4)
            {
                return true;
            }
            else if (month == 5)
            {
                return true;
            }
            else if (month == 6 && day <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            Console.WriteLine("Give a month and date of the year : ");
            int month = int.Parse(Console.ReadLine());
            int date = int.Parse(Console.ReadLine());
            SpringSeason obj = new SpringSeason();
            bool result = obj.CheckSpringSeason(month, date);
            if(result)
            {
                Console.WriteLine("It is a Spring season");
            }
            else
            {
                Console.WriteLine("It is not a Spring season");
            }
        }
    }
}
