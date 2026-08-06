using System.ComponentModel.DataAnnotations;

namespace HealthCareClinic.Models
{
    // Summary: Represents a doctor profile and assigned room details.
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }
        [Required(ErrorMessage = "Contact Number is Required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone Number must be of 10 digits")]
        public string ContactNumber { get; set; }
        [Required(ErrorMessage = "Contact Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid format for email")]
        public string ContactEmail { get; set; }
        public int RoomNumber { get; set; }

        // Creates an empty doctor object used when loading data from the database.
        public Doctor()
        {
        }

        // Creates a doctor object with the provided profile details.
        public Doctor(string firstName, string lastName, string specialization, string contactNumber, string contactEmail, int roomNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Specialization = specialization;
            ContactNumber = contactNumber;
            ContactEmail = contactEmail;
            RoomNumber = roomNumber;
        }
    }
}