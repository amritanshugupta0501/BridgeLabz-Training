using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinfunction.level2
{
    internal class NumberGuessingGame
    {
        static Random random = new Random();
        static void Main()
        {
            Console.WriteLine("Guess a number and system will try to guess it based on your feedback : ");
            GuessNumber();
        }
        static void GuessNumber()
        {
            bool isCorrect = false;
            int attempts = 0;
            int min = 1, max = 100;
            while (!isCorrect)
            {
                int number = random.Next(min, max + 1);
                Console.Write("Is the number you guessed \"" + number + "\" ? Say yes or no.");
                string result = Console.ReadLine();
                attempts++;
                result = result.ToLower();
                if (result.Equals("yes"))
                {
                    Console.WriteLine("Success I found your number in " + attempts + " .");
                    isCorrect = true;
                }
                else if (result.Equals("no"))
                {
                    Console.WriteLine("Give your feedback whether the number is high or low. Say high or low.");
                    string feedback = Console.ReadLine();
                    feedback = feedback.ToLower();
                    if (feedback.Equals("low"))
                    {
                        min = number + 1;
                    }
                    else
                    {
                        max = number - 1;
                    }
                }
            }
        }
    }
}
