using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.MovieManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        MovieManagementApplication list = new MovieManagementApplication();
            while (true)
            {

                Console.WriteLine("Movie Management System ");
                Console.WriteLine("1. Add at Beginning");
                Console.WriteLine("2. Add at End");
                Console.WriteLine("3. Add at Position");
                Console.WriteLine("4. Remove by Title");
                Console.WriteLine("5. Search by Director");
                Console.WriteLine("6. Search by Rating");
                Console.WriteLine("7. Display Forward");
                Console.WriteLine("8. Display Reverse");
                Console.WriteLine("9. Update Rating");
                Console.WriteLine("0. Back");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();
                if (choice == "0") break;

                switch (choice)
                {
                    case "1":
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Director: "); 
                        string director = Console.ReadLine();
                        Console.Write("Year: "); 
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Rating: "); 
                        double rating = double.Parse(Console.ReadLine());
                        list.AddAtBeginning(title, director, year, rating);
                        break;
                    case "2":
                        Console.Write("Title: ");
                        title = Console.ReadLine();
                        Console.Write("Director: ");
                        director = Console.ReadLine();
                        Console.Write("Year: ");
                        year = int.Parse(Console.ReadLine());
                        Console.Write("Rating: ");
                        rating = double.Parse(Console.ReadLine());
                        list.AddAtEnd(title, director, year, rating);
                        break;
                    case "3":
                        Console.Write("Position: "); 
                        int pos = int.Parse(Console.ReadLine());
                        Console.Write("Title: ");
                        title = Console.ReadLine();
                        Console.Write("Director: ");
                        director = Console.ReadLine();
                        Console.Write("Year: ");
                        year = int.Parse(Console.ReadLine());
                        Console.Write("Rating: ");
                        rating = double.Parse(Console.ReadLine());
                        list.AddAtPosition(pos, title, director, year, rating);
                        break;
                    case "4":
                        Console.Write("Title to Remove: ");
                        list.RemoveByTitle(Console.ReadLine());
                        break;
                    case "5":
                        Console.Write("Director: ");
                        list.SearchByDirector(Console.ReadLine());
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Write("Rating: ");
                        list.SearchByRating(double.Parse(Console.ReadLine()));
                        Console.ReadKey();
                        break;
                    case "7":
                        list.DisplayForward();
                        Console.ReadKey();
                        break;
                    case "8":
                        list.DisplayReverse();
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.Write("Title: "); 
                        title = Console.ReadLine();
                        Console.Write("New Rating: ");
                        rating = double.Parse(Console.ReadLine());
                        list.UpdateRating(title, rating);
                        break;
                }
            }
        }
    }
}
