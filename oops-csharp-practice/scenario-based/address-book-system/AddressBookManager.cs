using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBookSystem
{
    
    internal class AddressBookManager : IAddressBookManager
    {
        // UC - 06 : Defining multiple address books in the system with each one having a unique name of their own
        private IAddressBook[] AddressBook = new IAddressBook[100];
        static int CountAddressBooks;
        public void CreateANewAddressBook()
        {
            AddressBook[CountAddressBooks] = new AddressBookUtilityImpl();
            Console.Write("Give the name for your Address Book : ");
            string uniqueName = Console.ReadLine();
            AddressBook[CountAddressBooks].AddressBookName1 = uniqueName;
            CountAddressBooks++;
            Console.WriteLine("Address Book created!");
        }
        public void DisplayAllAddressBooks()
        {
            for (int loop = 0; loop < CountAddressBooks; loop++)
            {
                Console.WriteLine((loop + 1) + ". " + AddressBook[loop].AddressBookName1);
            }
            Console.WriteLine();
        }
        public IAddressBook SelectAnAddressBook()
        {
            DisplayAllAddressBooks();
            Console.Write("Select the address book you want to work upon : ");
            int addressBook = int.Parse(Console.ReadLine());
            return AddressBook[addressBook-1];
        }
        // UC - 08 : Search and display various persons in the whole system by their residential city or state
        public void SearchThroughDirectories()
        {
            for(int loop = 0; loop < CountAddressBooks;loop++)
            {
                AddressBook[loop].SearchThroughContactList();
            }
        }
    }
}
