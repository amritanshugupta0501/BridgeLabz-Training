using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.ranksheetgenerator
{
    // Menu class defined to to design the Home menu of the system
    sealed class RankSheetGeneratorMenu
    {
        IRankSheetGeneratorSystem RankGenerator;
        public void HomeMenu()
        {
            RankGenerator = new RankSheetGenerateSystemImpl();
            Console.WriteLine("Welcome To Rank Generating System!");
            while(true)
            {
                Console.WriteLine("1. Add a student to the system");
                Console.WriteLine("2. Display Rankings Of The students");
                Console.WriteLine("0. Exit the system");
                var choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        RankGenerator.AddAStudentInTheRanks();
                        break;
                    case "2":
                        RankGenerator.DisplayTheRankingList();
                        break;
                    case "0":
                        Console.WriteLine("Hope you have a good day!");
                        return;
                }
            }
        }
    }
}
