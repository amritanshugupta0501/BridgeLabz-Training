using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.ranksheetgenerator
{
    // Entry point of the application
    internal class RankingGenerateSystemMain
    {
        static void Main(string[] args)
        {
            RankSheetGeneratorMenu rankSheetGeneratorMenu = new RankSheetGeneratorMenu();
            rankSheetGeneratorMenu.HomeMenu();
        }
    }
}
