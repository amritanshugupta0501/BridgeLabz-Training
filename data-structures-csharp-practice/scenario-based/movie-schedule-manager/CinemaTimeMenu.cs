using BridgeLabzTraining.linkedlist.InventoryManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.movie_schedule_manager
{
    // Sealed class to prevent inheritance of the class
    sealed class CinemaTimeMenu
    {
        // Object of the interface(base class) to call functionalities of Utility(child) class
        IMovieManagement movieManager;
        // Function to design a menuu for the user
        public void HomeMenu()
        {
            movieManager = new MovieSchedulerImpl();
            Console.WriteLine("Welcome To Cinema Time Management Application!");
            while (true)
            {
                Console.WriteLine("1. Add a Movie");
                Console.WriteLine("2. View List of Movies");
                Console.WriteLine("3. Update a Movie");
                Console.WriteLine("4. Display details of All Movies");
                Console.WriteLine("5. Search for Movies");
                Console.WriteLine("0. Exit");
                Console.Write("Give your choice : ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 0:
                        Console.WriteLine("Thank you for your efforts!");
                        return;
                    case 1:
                        movieManager.AddAMovie();
                        break;
                    case 2:
                        movieManager.ViewListOfMovies();
                        break;
                    case 3:
                        movieManager.UpdateAMovie();
                        break;
                    case 4:
                        movieManager.DisplayAllTheMovies();
                        break;
                    case 5:
                        movieManager.SearchAMovie();
                        break;
                }
            }
        }
    }
}
