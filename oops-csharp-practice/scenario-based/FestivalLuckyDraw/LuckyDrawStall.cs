using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.FestivalLuckyDraw
{
    internal class LuckyDrawStall
    {
        int participants = 0;
        static void Main()                                                                          // Initialize the application for a lucky draw event
        {
            LuckyDrawStall luckyDraw = new LuckyDrawStall();
            luckyDraw.StartLuckyDraw();
        }
        void StartLuckyDraw()                                                                       // Start the lucky draw event and manage participants
        {
            Console.WriteLine("Welcome to the Festival Lucky Draw System!");
            Console.ReadLine();
            Console.WriteLine("Are you ready to try your luck ? ");
            Console.ReadLine();
            while (true)                                                                            // Loop to handle multiple participants
            {
                participants++;
                Console.WriteLine("Get Ready Participant number " + participants);
                LuckyDraw luckyDraw = new LuckyDraw();
                luckyDraw.SystemInitialize();
                Console.WriteLine("Are there any more participants ? Yes or No.");
                string response = Console.ReadLine().ToLower();
                if (response.ToLower() != "yes")
                {
                    Console.WriteLine("Thank you for participating in the Lucky Draw. Goodbye!");
                    break;
                }
            }
        }
    }
}