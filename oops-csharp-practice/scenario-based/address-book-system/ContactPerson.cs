using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBookSystem
{
    // UC - 01 : Ability to create a contact of a person with their first name, last name, email address,
    //           Contact Number, residential address, city, state, and area zip code
    internal class ContactPerson
    {
        private string PersonFirstName;
        private string PersonLastName;
        private string PersonEmail;
        private string PersonPhoneNumber;
        private string PersonAddress;
        private string PersonCity;
        private string PersonState;
        private string PersonZipCode;
        public string PersonFirstName1 { get => PersonFirstName; set => PersonFirstName = value; }
        public string PersonLastName1 { get => PersonLastName; set => PersonLastName = value; }
        public string PersonEmail1 { get => PersonEmail; set => PersonEmail = value; }
        public string PersonPhoneNumber1 { get => PersonPhoneNumber; set => PersonPhoneNumber = value; }
        public string PersonAddress1 { get => PersonAddress; set => PersonAddress = value; }
        public string PersonCity1 { get => PersonCity; set => PersonCity = value; }
        public string PersonState1 { get => PersonState; set => PersonState = value; }
        public string PersonZipCode1 { get => PersonZipCode; set => PersonZipCode = value; }
        public override string? ToString()
        {
            return $"Contact Person First Name : {PersonFirstName1}\n" +
                $"Person Last Name : {PersonLastName1}\n" +
                $"Person Email Address : {PersonEmail1}\n" +
                $"Person Contact Number : {PersonPhoneNumber1}\n" +
                $"Person Residential Address : {PersonAddress1}\n" +
                $"Person Residential City : {PersonCity1}\n"+
                $"Person Residential State : {PersonState1}\n" +
                $"Person Zip Code : {PersonZipCode1}\n";
        }
    }
}
