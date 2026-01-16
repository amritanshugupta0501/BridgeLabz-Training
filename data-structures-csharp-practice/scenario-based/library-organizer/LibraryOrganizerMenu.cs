using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.libraryorganizer
{
    // Sealed class to prevent inheritance of the Menu class
    sealed class LibraryOrganizerMenu
    {
        private ILibraryManagement Manager;
        // Function to design the Home Menu of the library organizer system
        public void HomeMenu()
        {
            Manager = new LibraryManageImpl();
            Console.WriteLine("Welcome to Library Organizer!");
            while (true)
            {
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. Display the book genre-wise");
                Console.WriteLine("3. Display Books of a Genre");
                Console.WriteLine("4. Remove a Book");
                Console.WriteLine("5. Borrow a Book");
                Console.WriteLine("6. Return a Book");
                Console.WriteLine("0. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Hope you have a good day!");
                        return;
                    case 1:
                        Manager.AddABookInLibrary();
                        break;
                    case 2:
                        Manager.DisplayBooks();
                        break;
                    case 3:
                        Manager.DisplayBooksInAGenre();
                        break;
                    case 4:
                        Manager.RemoveBook();
                        break;
                    case 5:
                        Manager.BorrowBook();
                        break;
                    case 6:
                        Manager.ReturnABook();
                        break;
                }
            }
        }
    }
}
