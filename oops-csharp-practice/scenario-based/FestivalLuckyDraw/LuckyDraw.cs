using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.FestivalLuckyDraw
{
    internal class LuckyDraw
    {
        Random random = new Random();    
        public void SystemInitialize()                                         // Initialize the random drawing of number for the participant
        {
            
            Console.WriteLine("Get Ready to try your luck.");
            Console.ReadLine();
            int number = DrawANumber();
            bool result = CheckResult(number);
            if(result)
            {
                Console.WriteLine("Congratulations! You have won the Prize.");
            }
            else
            {
                Console.WriteLine("Sorry! Better Luck next time.");
            }
        }
        int DrawANumber()                                                       // Function that generates a random number between 1 and 100
        {
            int luckyNumber = random.Next(1, 101); 
            Console.WriteLine($"Your lucky number is: {luckyNumber}");
            return luckyNumber;
        }
        bool CheckResult(int number)                                            // Checks if the number is divisible by 3 and 5
        {
            return number % 3 == 0 && number % 5 == 0;
        }
    }
}
