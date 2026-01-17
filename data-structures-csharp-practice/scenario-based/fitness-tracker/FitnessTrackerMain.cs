using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.fitnesstracker
{
    // Entry point of the fitness tracker application
    internal class FitnessTrackerMain
    {
        static void Main(string[] args)
        {
            FitnessTrackerMenu fitnessTracker = new FitnessTrackerMenu();
            fitnessTracker.HomeMenu();
        }
    }
}
