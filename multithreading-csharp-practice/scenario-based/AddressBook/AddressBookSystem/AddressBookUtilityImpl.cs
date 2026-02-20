using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace AddressBook.AddressBookSystem
{
    internal class AddressBookUtilityImpl : IAddressBook
    {
        // UC -14 : Using CSV File to perform read and write operations on entries
        private const string DefaultCsvPath = @"c:\Users\Asus\source\repos\AddressBook\sample_contacts.csv";
        // UC -15 : Using JSON File to perform read and write operations on entries
        private const string DefaultJsonPath = @"c:\Users\Asus\source\repos\AddressBook\sample_contacts.json";
        // UC - 05 : Adding mulitple contact person's details to the Address Book using Array
        private string AddressBookName;
        private LinkedList<ContactPerson> ContactPersonsList = new LinkedList<ContactPerson>();
        public string AddressBookName1 { get => AddressBookName; set => AddressBookName = value; }

        // UC - 02 : Adding every detail of the contact person to the list from the console.
        public void AddAContactPerson()
        {
            var person = new ContactPerson();
            Console.WriteLine("Give the Contact Person Details : ");
            Console.Write("First Name : ");
            person.PersonFirstName1 = Console.ReadLine();
            Console.Write("Last Name : ");
            person.PersonLastName1 = Console.ReadLine();
            Console.Write("Email Address : ");
            person.PersonEmail1 = Console.ReadLine();
            Console.Write("Contact Number : ");
            person.PersonPhoneNumber1 = Console.ReadLine();
            Console.Write("Residential Address : ");
            person.PersonAddress1 = Console.ReadLine();
            Console.Write("Residential City : ");
            person.PersonCity1 = Console.ReadLine();
            Console.Write("Residential State : ");
            person.PersonState1 = Console.ReadLine();
            Console.Write("Residential Zip Code : ");
            person.PersonZipCode1 = Console.ReadLine();
            if (CheckDuplicate(person))
            {
                ContactPersonsList.AddLast(person);
            }
        }
        // Function to display every contact person's detail in the list
        public void DisplayContactsInTheList()
        {
            foreach (var person in ContactPersonsList)
            {
                Console.WriteLine(person.ToString());
            }
        }
        // UC - 03 : Searching and editing a contact detail by the name of the contact person.
        public void EditContactDetailsByName()
        {
            Console.Write("Give the full name of the contact you want to update : ");
            string contactName = Console.ReadLine();
            foreach (var c in ContactPersonsList)
            {
                string personName = (c.PersonFirstName1 + " " + c.PersonLastName1).ToLower();
                if (personName.Equals(contactName.ToLower()))
                {
                    Console.WriteLine("Select the details you want to update : \n1. First Name\n2. Last Name\n3. Email Address\n4. Contact Number\n" +
                        "5. Residential Address\n6. Residential City\n7. Residential State\n8. ZIP Code");
                    if(int.TryParse(Console.ReadLine(), out int choice))
                    {
                        Console.Write("Give the updated details : ");
                        switch(choice)
                        {
                            case 1:
                                c.PersonFirstName1 = Console.ReadLine();
                                Console.WriteLine("First Name Updated.");
                                break;
                            case 2:
                                c.PersonLastName1 = Console.ReadLine();
                                Console.WriteLine("Last Name Updated.");
                                break;
                            case 3:
                                c.PersonEmail1 = Console.ReadLine();
                                Console.WriteLine("Email Address Updated.");
                                break;
                            case 4:
                                c.PersonPhoneNumber1 = Console.ReadLine();
                                Console.WriteLine("Contact Number Updated.");
                                break;
                            case 5:
                                c.PersonAddress1 = Console.ReadLine();
                                Console.WriteLine("Residential Address Updated.");
                                break;
                            case 6:
                                c.PersonCity1 = Console.ReadLine();
                                Console.WriteLine("Residential City Updated.");
                                break;
                            case 7:
                                c.PersonState1 = Console.ReadLine();
                                Console.WriteLine("Residential State Updated.");
                                break;
                            case 8:
                                c.PersonZipCode1 = Console.ReadLine();
                                Console.WriteLine("Zip Code Updated.");
                                break;
                            default:
                                Console.WriteLine("Invalid choice input.");
                                break;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice input.");
                    }
                    return;
                }
            }
            Console.WriteLine("The contact name does not exist in the address book. Perhaps you would like to add a new entry in the address book.");
        }
        // UC - 04 : Searching and removing a contact person's details using the name of the contact person.
        public void RemoveAUserByName()
        {
            Console.Write("Give the full name of the contact you want to delete from the address book : ");
            string contactName = Console.ReadLine();
            foreach (var c in ContactPersonsList)
            {
                string personName = (c.PersonFirstName1 + " " + c.PersonLastName1).ToLower();
                if (personName.Equals(contactName.ToLower()))
                {
                    ContactPersonsList.Remove(c);
                    Console.WriteLine("Contact removed.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }
        // UC - 07 : Ensuring that no duplicate entry has been entered in our address book directory
        public bool CheckDuplicate(ContactPerson newContact)
        {
            foreach (var c in ContactPersonsList)
            {
                if (c.ToString().Equals(newContact.ToString()))
                {
                    Console.WriteLine("Duplicate contact detected. Skipping add.");
                    return false;
                }
            }
            return true;
        }
        // UC - 09 : Searching and displaying contacts by their city or state of residence
        public void SearchThroughContactList()
        {
            Console.Write("Give the name of the state or the city : ");
            string searchRegion = Console.ReadLine();
            foreach (var c in ContactPersonsList)
            {
                if ((c.PersonState1 != null && c.PersonState1.Equals(searchRegion, StringComparison.OrdinalIgnoreCase)) ||
                    (c.PersonCity1 != null && c.PersonCity1.Equals(searchRegion, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine(c.ToString());
                }
            }
        }
        // UC - 10 : Counting users from a given state or city within a directory of address book
        public void CountUsersFromARegion()
        {
            Console.Write("Give the name of the state or the city : ");
            string searchRegion = Console.ReadLine();
            int countUsers = 0;
            foreach (var c in ContactPersonsList)
            {
                if ((c.PersonState1 != null && c.PersonState1.Equals(searchRegion, StringComparison.OrdinalIgnoreCase)) ||
                    (c.PersonCity1 != null && c.PersonCity1.Equals(searchRegion, StringComparison.OrdinalIgnoreCase)))
                {
                    countUsers++;
                }
            }
            Console.WriteLine($"Number of users from {searchRegion} : {countUsers}");
        }
        // UC - 11 : Sorting the address book alphabetically by first name
        public void SortUsersInAnOrderedManner()
        {
            var list = ContactPersonsList.ToList();
            list.Sort((a, b) => string.Compare(a?.PersonFirstName1, b?.PersonFirstName1, StringComparison.OrdinalIgnoreCase));
            ContactPersonsList.Clear();
            foreach (var c in list)
            {
                ContactPersonsList.AddLast(c);
            }
        }

        // UC - 12 : Sorting entries by city, state and zip
        public void SortUsersByCity()
        {
            var list = ContactPersonsList.ToList();
            list.Sort((a, b) => string.Compare(a?.PersonCity1, b?.PersonCity1, StringComparison.OrdinalIgnoreCase));
            ContactPersonsList.Clear();
            foreach (var c in list)
            {
                ContactPersonsList.AddLast(c);
            }
        }
        public void SortUsersByState()
        {
            var list = ContactPersonsList.ToList();
            list.Sort((a, b) => string.Compare(a?.PersonState1, b?.PersonState1, StringComparison.OrdinalIgnoreCase));
            ContactPersonsList.Clear();
            foreach (var c in list)
            {
                ContactPersonsList.AddLast(c);
            }
        }
        public void SortUsersByZip()
        {
            var list = ContactPersonsList.ToList();
            list.Sort((a, b) => string.Compare(a?.PersonZipCode1, b?.PersonZipCode1, StringComparison.OrdinalIgnoreCase));
            ContactPersonsList.Clear();
            foreach (var c in list)
            {
                ContactPersonsList.AddLast(c);
            }
        }
        // UC - 13 : file IO operations 
        private void SaveCsvSync(string path)
        {
            using var writer = new StreamWriter(path);
            foreach (var person in ContactPersonsList.ToList())
            {
                string line = string.Join(",",
                    person.PersonFirstName1?.Replace(",", ";"),
                    person.PersonLastName1?.Replace(",", ";"),
                    person.PersonEmail1?.Replace(",", ";"),
                    person.PersonPhoneNumber1?.Replace(",", ";"),
                    person.PersonAddress1?.Replace(",", ";"),
                    person.PersonCity1?.Replace(",", ";"),
                    person.PersonState1?.Replace(",", ";"),
                    person.PersonZipCode1?.Replace(",", ";"));
                writer.WriteLine(line);
            }
        }

        private IEnumerable<ContactPerson> LoadCsvSync(string path)
        {
            var list = new List<ContactPerson>();
            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split(',');
                if (parts.Length < 8) continue;
                list.Add(new ContactPerson
                {
                    PersonFirstName1 = parts[0].Replace(";", ","),
                    PersonLastName1 = parts[1].Replace(";", ","),
                    PersonEmail1 = parts[2].Replace(";", ","),
                    PersonPhoneNumber1 = parts[3].Replace(";", ","),
                    PersonAddress1 = parts[4].Replace(";", ","),
                    PersonCity1 = parts[5].Replace(";", ","),
                    PersonState1 = parts[6].Replace(";", ","),
                    PersonZipCode1 = parts[7].Replace(";", ","),
                });
            }
            return list;
        }
        // UC - 17 : Asynchronized CRUD operations in CSV And JSON Files
        public async System.Threading.Tasks.Task SaveToCsvAsync()
        {
            Console.Write($"Enter filename (with path if desired) to save entries [ENTER for default: {DefaultCsvPath}]: ");
            string path = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(path)) path = DefaultCsvPath;
            try
            {
                var listCopy = ContactPersonsList.ToList();
                using var writer = new StreamWriter(path);
                foreach (var person in listCopy)
                {
                    string line = string.Join(",",
                        person.PersonFirstName1?.Replace(",", ";"),
                        person.PersonLastName1?.Replace(",", ";"),
                        person.PersonEmail1?.Replace(",", ";"),
                        person.PersonPhoneNumber1?.Replace(",", ";"),
                        person.PersonAddress1?.Replace(",", ";"),
                        person.PersonCity1?.Replace(",", ";"),
                        person.PersonState1?.Replace(",", ";"),
                        person.PersonZipCode1?.Replace(",", ";"));
                    await writer.WriteLineAsync(line);
                }
                Console.WriteLine($"Entries saved to {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing file: {ex.Message}");
            }
        }

        public async System.Threading.Tasks.Task LoadFromCsvAsync()
        {
            Console.Write($"Enter filename (with path if needed) to load entries from [ENTER for default: {DefaultCsvPath}]: ");
            string path = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(path)) path = DefaultCsvPath;
            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist.");
                return;
            }
            try
            {
                var lines = await File.ReadAllLinesAsync(path);
                var newList = new LinkedList<ContactPerson>();
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length < 8) continue;
                    newList.AddLast(new ContactPerson
                    {
                        PersonFirstName1 = parts[0].Replace(";", ","),
                        PersonLastName1 = parts[1].Replace(";", ","),
                        PersonEmail1 = parts[2].Replace(";", ","),
                        PersonPhoneNumber1 = parts[3].Replace(";", ","),
                        PersonAddress1 = parts[4].Replace(";", ","),
                        PersonCity1 = parts[5].Replace(";", ","),
                        PersonState1 = parts[6].Replace(";", ","),
                        PersonZipCode1 = parts[7].Replace(";", ","),
                    });
                }
                ContactPersonsList = newList;
                Console.WriteLine($"Entries loaded from {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }

        public async System.Threading.Tasks.Task SaveToJsonAsync()
        {
            Console.Write($"Enter filename (with path if desired) to save JSON [ENTER default: {DefaultJsonPath}]: ");
            string path = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(path)) path = DefaultJsonPath;
            try
            {
                var listCopy = ContactPersonsList.ToList();
                var options = new JsonSerializerOptions { WriteIndented = true };
                using var stream = File.Create(path);
                await JsonSerializer.SerializeAsync(stream, listCopy, options);
                Console.WriteLine($"Entries saved to {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing JSON file: {ex.Message}");
            }
        }

        public async System.Threading.Tasks.Task LoadFromJsonAsync()
        {
            Console.Write($"Enter filename (with path if needed) to load JSON [ENTER default: {DefaultJsonPath}]: ");
            string path = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(path)) path = DefaultJsonPath;
            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist.");
                return;
            }
            try
            {
                using var stream = File.OpenRead(path);
                var list = await JsonSerializer.DeserializeAsync<List<ContactPerson>>(stream);
                if (list != null)
                {
                    ContactPersonsList = new LinkedList<ContactPerson>(list);
                }
                Console.WriteLine($"Entries loaded from {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading JSON file: {ex.Message}");
            }
        }
    }
}
