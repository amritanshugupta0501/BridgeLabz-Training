using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBookSystem
{
    internal class AddressBookUtilityImpl : IAddressBook
    {
        // UC - 05 : Adding mulitple contact person's details to the Address Book using Array
        private string AddressBookName;
        ContactPerson[] ContactPersonsList = new ContactPerson[100];
        int CountContactPerson;

        public string AddressBookName1 { get => AddressBookName; set => AddressBookName = value; }

        // UC - 02 : Adding every detail of the contact person to the list from the console.
        public void AddAContactPerson()
        {
            ContactPersonsList[CountContactPerson] = new ContactPerson();
            Console.WriteLine("Give the Contact Person Details : ");
            Console.Write("First Name : ");
            ContactPersonsList[CountContactPerson].PersonFirstName1 = Console.ReadLine();
            Console.Write("Last Name : ");
            ContactPersonsList[CountContactPerson].PersonLastName1 = Console.ReadLine();
            Console.Write("Email Address : ");
            ContactPersonsList[CountContactPerson].PersonEmail1 = Console.ReadLine();
            Console.Write("Contact Number : ");
            ContactPersonsList[CountContactPerson].PersonPhoneNumber1 = Console.ReadLine();
            Console.Write("Residential Address : ");
            ContactPersonsList[CountContactPerson].PersonAddress1 = Console.ReadLine();
            Console.Write("Residential City : ");
            ContactPersonsList[CountContactPerson].PersonCity1 = Console.ReadLine();
            Console.Write("Residential State : ");
            ContactPersonsList[CountContactPerson].PersonState1 = Console.ReadLine();
            Console.Write("Residential Zip Code : ");
            ContactPersonsList[CountContactPerson].PersonZipCode1 = Console.ReadLine();
            CountContactPerson++;
        }
        // Function to display every contact person's detail in the list
        public void DisplayContactsInTheList()
        {
            for(int loop = 0; loop < CountContactPerson; loop++)
            {
                Console.WriteLine(ContactPersonsList[loop].ToString());
            }
        }
        // UC - 03 : Searching and editing a contact detail by the name of the contact person.
        public void EditContactDetailsByName()
        {
            Console.Write("Give the full name of the contact you want to update : ");
            string contactName = Console.ReadLine();
            for (int loop = 0; loop < CountContactPerson; loop++)
            {
                string personName = ContactPersonsList[loop].PersonFirstName1 +" "+ ContactPersonsList[loop].PersonLastName1;
                if (personName.ToLower().Equals(contactName.ToLower()))
                {
                    Console.WriteLine("Select the details you want to update : \n1. First Name\n2. Last Name\n3. Email Address\n4. Contact Number\n" +
                        "5. Residential Address\n6. Residential City\n7. Residential State\n8. ZIP Code");
                    if(int.TryParse(Console.ReadLine(), out int choice))
                    {
                        Console.Write("Give the updated details : ");
                        switch(choice)
                        {
                            case 1:
                                ContactPersonsList[loop].PersonFirstName1 = Console.ReadLine();
                                Console.WriteLine("First Name Updated.");
                                break;
                            case 2:
                                ContactPersonsList[loop].PersonLastName1 = Console.ReadLine();
                                Console.WriteLine("Last Name Updated.");
                                break;
                            case 3:
                                ContactPersonsList[loop].PersonEmail1 = Console.ReadLine();
                                Console.WriteLine("Email Address Updated.");
                                break;
                            case 4:
                                ContactPersonsList[loop].PersonPhoneNumber1 = Console.ReadLine();
                                Console.WriteLine("Contact Number Updated.");
                                break;
                            case 5:
                                ContactPersonsList[loop].PersonAddress1 = Console.ReadLine();
                                Console.WriteLine("Residential Address Updated.");
                                break;
                            case 6:
                                ContactPersonsList[loop].PersonCity1 = Console.ReadLine();
                                Console.WriteLine("Residential City Updated.");
                                break;
                            case 7:
                                ContactPersonsList[loop].PersonState1 = Console.ReadLine();
                                Console.WriteLine("Residential State Updated.");
                                break;
                            case 8:
                                ContactPersonsList[loop].PersonZipCode1 = Console.ReadLine();
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
            for (int loop = 0; loop < CountContactPerson; loop++)
            {
                string personName = ContactPersonsList[loop].PersonFirstName1 + " " + ContactPersonsList[loop].PersonLastName1;
                if (personName.ToLower().Equals(contactName.ToLower()))
                {
                    ContactPersonsList[loop] = null;
                    for (int loop2 = loop; loop2 < CountContactPerson-1; loop2++)
                    {
                        ContactPersonsList[loop2] = ContactPersonsList[loop+1];
                    }
                    CountContactPerson--;
                }
            }
        }
    }
}
