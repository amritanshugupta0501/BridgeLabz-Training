using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryManagementApplication lib = new LibraryManagementApplication();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Library System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Search Book");
                Console.WriteLine("4. Update Availability");
                Console.WriteLine("5. Display Forward");
                Console.WriteLine("6. Display Reverse");
                Console.WriteLine("7. Count Books");
                Console.WriteLine("0. Back");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();
                if (choice == "0")
                {
                    break;
                }
                switch (choice)
                {
                    case "1":
                        Console.Write("ID: "); 
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Title: "); 
                        string title = Console.ReadLine();
                        Console.Write("Author: "); 
                        string auth = Console.ReadLine();
                        Console.Write("Genre: "); 
                        string genre = Console.ReadLine();
                        lib.AddBook(id, title, auth, genre, true);
                        break;
                    case "2":
                        Console.Write("ID to Remove: ");
                        lib.RemoveBook(int.Parse(Console.ReadLine()));
                        break;
                    case "3":
                        Console.Write("Title or Author: ");
                        lib.SearchBook(Console.ReadLine());
                        break;
                    case "4":
                        Console.Write("ID: "); 
                        int uid = int.Parse(Console.ReadLine());
                        Console.Write("Is Available (true/false): "); 
                        bool av = bool.Parse(Console.ReadLine());
                        lib.UpdateAvailability(uid, av);
                        break;
                    case "5":
                        lib.DisplayBooks(false);
                        break;
                    case "6":
                        lib.DisplayBooks(true);
                        break;
                    case "7":
                        Console.WriteLine($"Total Books: {lib.CountBooks()}");
                        break;
                }
            }
        }
    }
}
