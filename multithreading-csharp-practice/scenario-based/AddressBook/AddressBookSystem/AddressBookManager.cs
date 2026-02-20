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
        private Dictionary<string, IAddressBook> AddressBooks = new Dictionary<string, IAddressBook>(StringComparer.OrdinalIgnoreCase);

        public void CreateANewAddressBook()
        {
            Console.Write("Give the name for your Address Book : ");
            string uniqueName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(uniqueName))
            {
                Console.WriteLine("Invalid name. Aborting creation.");
                return;
            }
            if (AddressBooks.ContainsKey(uniqueName))
            {
                Console.WriteLine("An address book with that name already exists.");
                return;
            }
            var book = new AddressBookUtilityImpl();
            book.AddressBookName1 = uniqueName;
            AddressBooks.Add(uniqueName, book);
            Console.WriteLine("Address Book created!");
        }

        public void DisplayAllAddressBooks()
        {
            int i = 1;
            foreach (var kv in AddressBooks)
            {
                Console.WriteLine((i++) + ". " + kv.Value.AddressBookName1);
            }
            Console.WriteLine();
        }

        public IAddressBook SelectAnAddressBook()
        {
            if (AddressBooks.Count == 0)
            {
                Console.WriteLine("No address books available.");
                return null;
            }
            DisplayAllAddressBooks();
            Console.Write("Select the address book you want to work upon (enter number): ");
            if (!int.TryParse(Console.ReadLine(), out int addressBook) || addressBook < 1 || addressBook > AddressBooks.Count)
            {
                Console.WriteLine("Invalid selection.");
                return null;
            }
            return AddressBooks.ElementAt(addressBook - 1).Value;
        }

        // UC - 08 : Search and display various persons in the whole system by their residential city or state
        public void SearchThroughDirectories()
        {
            foreach (var book in AddressBooks.Values)
            {
                book.SearchThroughContactList();
            }
        }
    }
}
