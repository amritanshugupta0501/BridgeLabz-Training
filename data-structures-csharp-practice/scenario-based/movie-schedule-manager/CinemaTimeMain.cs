using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.movie_schedule_manager
{
    // Entry point of the application
    internal class CinemaTimeMain
    {
        static void Main(string[] args)
        {
            CinemaTimeMenu cinemaTimeMenu = new CinemaTimeMenu();
            cinemaTimeMenu.HomeMenu();
        }
    }
}
