using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBookSystem
{
    // Using sealed class to prevent inheritance of the menu class
    sealed class AddressBookMenu
    {
        // Object created using parent reference i.e. Interface IAddressBook to call the functionalities of the child class
        private IAddressBook AddressBook;
        // Function to design the home menu of the application
        public void HomeMenu()
        {
            IAddressBookManager manageAddressBooks = new AddressBookManager();
            Console.WriteLine("Welcome to Address Book System Application!");
            while (true)
            {
                Console.WriteLine("1. Create an Address Book");
                Console.WriteLine("2. Display all Address Books");
                Console.WriteLine("3. Work in an Address Book");
                Console.WriteLine("4. View Entries by their city or state");
                Console.WriteLine("0. Exit the application");
                Console.Write("Select the option : ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0)
                {
                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("Thank you for using our platform! Hope you have a good day!");
                            return;
                        case 1:
                            manageAddressBooks.CreateANewAddressBook();
                            break;
                        case 2:
                            manageAddressBooks.DisplayAllAddressBooks();
                            break;
                        case 3:
                            AddressBook = manageAddressBooks.SelectAnAddressBook();
                            HomeMenuOfAnAddressBook();
                            break;
                        case 4:
                            manageAddressBooks.SearchThroughDirectories();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option selected.");
                }
            }
        }
        public void HomeMenuOfAnAddressBook()
        {
            AddressBook = new AddressBookUtilityImpl();
            while (true)
            {
                Console.WriteLine("Home Menu");
                Console.WriteLine("1. Add an entry to the address book");
                Console.WriteLine("2. Display entries within the address book");
                Console.WriteLine("3. Edit A Contact using Name");
                Console.WriteLine("4. Remove a User by their Name");
                Console.WriteLine("5. View a User by their City or State");
                Console.WriteLine("0. Exit");
                Console.Write("Select the option : ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0)
                {
                    switch(choice)
                    {
                        case 0:
                            Console.WriteLine();
                            return;
                        case 1:
                            AddressBook.AddAContactPerson();
                            break;
                        case 2:
                            AddressBook.DisplayContactsInTheList();
                            break;
                        case 3:
                            AddressBook.EditContactDetailsByName();
                            break;
                        case 4:
                            AddressBook.RemoveAUserByName();
                            break;
                        case 5:
                            AddressBook.SearchThroughContactList();
                            break;
                    }
                }
            }
        }
    }
}
