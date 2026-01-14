using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBookSystem
{
    internal class AddressBookUtilityImpl : IAddressBook
    {
        ContactPerson[] ContactPersonsList = new ContactPerson[100];
        static int CountContactPerson;
        // UC - 02 : Adding every detail of the contact person to the list from the console
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
    }
}
