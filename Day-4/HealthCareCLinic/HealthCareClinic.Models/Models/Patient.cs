using System.ComponentModel.DataAnnotations;

namespace HealthCareClinic.Models
{
    // Summary: Represents a patient profile and medical details.
    public class Patient
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public string DateOfBirth { get; set; }
        [Required(ErrorMessage = "Contact Number is Required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone Number must be of 10 digits")]
        public string ContactNumber { get; set; }
        [Required(ErrorMessage = "Contact Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid format for email")]
        public string ContactEmail { get; set; }
        public string ResidenceAddress { get; set; }
        public string MedicalDescription { get; set; }
        public string Medication { get; set; }
        public int? DoctorID { get; set; }

        // Creates an empty patient object used when loading data from the database.
        public Patient()
        {
        }

        // Creates a patient object with the provided personal and medical details.
        public Patient(string firstName, string lastName, char gender, string dateOfBirth, string contactNumber, string contactEmail, string residenceAddress, string medicalDescription, string medication, int? doctorID)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            ContactNumber = contactNumber;
            ContactEmail = contactEmail;
            ResidenceAddress = residenceAddress;
            MedicalDescription = medicalDescription;
            Medication = medication;
            DoctorID = doctorID;
        }
    }
}