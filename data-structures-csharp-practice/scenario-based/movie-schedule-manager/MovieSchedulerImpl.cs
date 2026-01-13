using BridgeLabzTraining.linkedlist.InventoryManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.movie_schedule_manager
{
    // Utility class for the application
    internal class MovieSchedulerImpl : IMovieManagement
    {
        Movie Head;
        // Function to add a movie to the application
        public void AddAMovie()
        {
            Console.WriteLine("Give Movie Details : ");
            Console.Write("Movie Title : ");
            string movieTitle = Console.ReadLine();
            Console.Write("Movie Director : ");
            string movieDirector = Console.ReadLine();
            Console.Write("Movie Genre : ");
            string movieGenre = Console.ReadLine();
            Console.Write("Movie Hours : ");
            string movieHours = Console.ReadLine();
            Console.Write("Show Timings for the Movie : ");
            string movieShowTiming = Console.ReadLine();
            Movie newMovie = new Movie(movieTitle, movieDirector, movieGenre, movieHours, movieShowTiming);
            if (Head == null)
            {
                Head = newMovie;
            }
            else
            {
                Movie current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newMovie;
            }
        }
        // Function to display all the movies in the system
        public void DisplayAllTheMovies()
        {
            Movie current = Head;
            while (current != null)
            {
                Console.WriteLine(current.ToString());
                current = current.Next;
            }
        }
        // Function to update a movie in the system
        public void UpdateAMovie()
        {
            Console.WriteLine("Select the criteria to search for the movie : \n1. Title\n2. Genre");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Give the criteria you want to search the movie with : ");
            string criteria = Console.ReadLine();
            switch (choice)
            {
                case 1:
                    SearchMovieByTitle(criteria);
                    break;
                case 2:
                    SearchMovieByGenre(criteria);
                    break;
            }
            Console.Write("Select the movie you want to update : ");
            int movieIndex = int.Parse(Console.ReadLine());
            Movie current = Head;
            while (movieIndex != 1&&movieIndex>0)
            {
                current = current.Next;
                movieIndex--;
            }
            UpdateDetailsOfMovie(current.MovieTitle1);
        }
        public void UpdateDetailsOfMovie(string criteria)
        {
            Movie current = Head;
            while (current != null)
            {
                if(current.MovieTitle1.Equals(criteria))
                {
                    Console.WriteLine("Select What you want to update : ");
                    Console.WriteLine("1. Movie Title\n2. Movie Director\n3. Movie Genre\n4. Movie Hours\n5. Show Timings");
                    int choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            Console.Write("Give the updated Movie Title : ");
                            current.MovieTitle1 = Console.ReadLine();
                            return;
                        case 2:
                            Console.Write("Give the updated Movie Director : ");
                            current.MovieDirector1 = Console.ReadLine();
                            return;
                        case 3:
                            Console.Write("Give the updated Movie Title : ");
                            current.MovieGenre1 = Console.ReadLine();
                            return;
                        case 4:
                            Console.Write("Give the updated Movie Title : ");
                            current.MovieHours1 = Console.ReadLine();
                            return;
                        case 5:
                            Console.Write("Give the updated Movie Title : ");
                            current.MovieShowTiming1 = Console.ReadLine();
                            return;
                        default:
                            return;
                    }
                }
                current = current.Next;
            }
        }
        // Function to search a movie within the list
        public void SearchAMovie()
        {
            Console.WriteLine("Search Movie By : \n1. Title\n2. Genre");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Give the keyword for the title : ");
                    string keyword = Console.ReadLine();
                    SearchMovieByTitle(keyword);
                    break;
                case 2:
                    Console.Write("Give the keyword for the genre : ");
                    keyword = Console.ReadLine();
                    SearchMovieByGenre(keyword);
                    break;
            }
        }
        public void SearchMovieByTitle(string keyword)
        {
            int position;
            Movie current = Head;
            position = 1;
            while (current != null)
            {
                if (current.MovieTitle1.Contains(keyword))
                {
                    Console.WriteLine((position++)+". "+current.MovieTitle1);
                }
                current = current.Next;
            }
        }
        public void SearchMovieByGenre(string keyword)
        {
            int position;
            Movie current = Head;
            position = 1;
            while (current != null)
            {
                if (current.MovieGenre1.Contains(keyword))
                {
                    Console.WriteLine((position++) + ". " + current.MovieTitle1);
                }
                current = current.Next;
            }
        }
        public void ViewListOfMovies()
        {
            int index;
            Movie current = Head;
            index = 1;
            while (current != null)
            {
                Console.WriteLine((index++)+". "+current.MovieTitle1);
                current = current.Next;
            }
        }
    }
}
