using System;
using System.Collections.Generic;
using HealthCareClinic.Models;
using HealthCareClinic.Controller;

namespace HealthCareClinic.Services
{
    // Summary: Contains business logic for managing patient data.
    public class PatientService : IHealthCareClinicServices
    {
        private readonly IHealthCareClinicRepository<Patient> _patientRepo;

        public PatientService(IHealthCareClinicRepository<Patient> patientRepo)
        {
            _patientRepo = patientRepo;
        }

        // Collects patient details from the user and stores the new record.
        public void AddDetails()
        {
            Console.WriteLine("Give Doctor Details : ");
            Console.Write("First Name : ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Gender (M | F) : ");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Date Of Birth : ");
            string dateOfBirth = Console.ReadLine();
            Console.Write("Contact Number : ");
            string contactNumber = Console.ReadLine();
            Console.Write("Contact Email : ");
            string contactEmail = Console.ReadLine();
            Console.Write("Residence Address : ");
            string residenceAddress = Console.ReadLine();
            Console.Write("Medical Description : ");
            string medicalDescription = Console.ReadLine();
            Console.Write("Medication : ");
            string medication = Console.ReadLine();
            Console.Write("Enter the assigned Doctor ID (Leave blank if not assigned) : ");
            int? doctorId = null;
            string doctorID = Console.ReadLine();
            if (!int.TryParse(doctorID, out int docId))
            {
                doctorId = docId;
            }
            Patient patient = new Patient(firstName, lastName, gender, dateOfBirth, contactNumber, contactEmail, residenceAddress, medicalDescription, medication, doctorId);
            bool isSuccess = _patientRepo.Add(patient);
            if (isSuccess)
            {
                Console.WriteLine("Success : Patient inserted successfully");
            }
            else
            {
                Console.WriteLine("Failure : Could not add Patient, data is invalid");
            }
        }

        // Displays every patient record currently stored in the repository.
        public void DisplayAll()
        {
            Console.WriteLine("List of all Doctors");
            var patients = _patientRepo.GetAllData();
            if (patients == null || patients.Count == 0)
            {
                Console.WriteLine("No Doctors exist in the database");
            }
            else
            {
                foreach (var patient in patients)
                {
                    Console.WriteLine($"Patient ID : {patient.DoctorID}");
                    Console.WriteLine($"First Name : {patient.FirstName}");
                    Console.WriteLine($"Last Name : {patient.LastName}");
                    Console.WriteLine($"Gender : {patient.Gender}");
                    Console.WriteLine($"Date Of Birth : {patient.DateOfBirth}");
                    Console.WriteLine($"Contact Number : {patient.ContactNumber}");
                    Console.WriteLine($"Contact Email: {patient.ContactEmail}");
                    Console.WriteLine($"Residence Address : {patient.ResidenceAddress}");
                    Console.WriteLine($"Medical Description : {patient.MedicalDescription}");
                    Console.WriteLine($"Medication : {patient.Medication}");
                    Console.WriteLine($"Doctor ID : {patient.DoctorID}");
                    Console.WriteLine();
                }
            }
        }

        // Searches for and displays a single patient by their ID.
        public void DisplayById()
        {
            Console.Write("Give the Patient ID to search : ");
            int patientID = Convert.ToInt32(Console.ReadLine());
            var patient = _patientRepo.GetDataById(patientID);
            if (patient == null)
            {
                Console.WriteLine("No doctor with the given id");
            }
            else
            {
                Console.WriteLine($"Patient ID : {patient.DoctorID}");
                Console.WriteLine($"First Name : {patient.FirstName}");
                Console.WriteLine($"Last Name : {patient.LastName}");
                Console.WriteLine($"Gender : {patient.Gender}");
                Console.WriteLine($"Date Of Birth : {patient.DateOfBirth}");
                Console.WriteLine($"Contact Number : {patient.ContactNumber}");
                Console.WriteLine($"Contact Email: {patient.ContactEmail}");
                Console.WriteLine($"Residence Address : {patient.ResidenceAddress}");
                Console.WriteLine($"Medical Description : {patient.MedicalDescription}");
                Console.WriteLine($"Medication : {patient.Medication}");
                Console.WriteLine($"Doctor ID : {patient.DoctorID}");
                Console.WriteLine();
            }
        }

        // Updates the selected patient's information through an interactive menu.
        public void UpdateDetails()
        {
            Console.WriteLine("Enter the Patient ID you want to update : ");
            int patientID = Convert.ToInt32(Console.ReadLine());
            Patient existingPatient = _patientRepo.GetDataById(patientID);
            if (existingPatient == null)
            {
                Console.WriteLine("Failure : No doctor with the given Id");
                return;
            }

            bool keepUpdating = true;
            while (keepUpdating)
            {
                Console.WriteLine($"Updating Doctor {existingPatient.FirstName} {existingPatient.LastName}");
                Console.WriteLine("1. Update First Name");
                Console.WriteLine("2. Update Last Name");
                Console.WriteLine("3. Update Gender");
                Console.WriteLine("4. Update Date Of Birth");
                Console.WriteLine("5. Update Contact Number");
                Console.WriteLine("6. Update Contact Email");
                Console.WriteLine("7. Update Residence Address");
                Console.WriteLine("8. Update Medical Description");
                Console.WriteLine("9. Update Medication");
                Console.WriteLine("10. Update Doctor ID");
                Console.WriteLine("11. Save Updates");
                Console.WriteLine("Choose details to update.");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingPatient.FirstName = Console.ReadLine();
                        break;
                    case "2" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingPatient.LastName = Console.ReadLine();
                        break;
                    case "3" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingPatient.Gender = char.Parse(Console.ReadLine());
                        break;
                    case "4" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingPatient.DateOfBirth = Console.ReadLine();
                        break;
                    case "5" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingPatient.ContactNumber = Console.ReadLine();
                        break;
                    case "6" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingPatient.ContactEmail = Console.ReadLine();
                        break;
                    case "7" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingPatient.ResidenceAddress = Console.ReadLine();
                        break;
                    case "8" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingPatient.MedicalDescription = Console.ReadLine();
                        break;
                    case "9" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingPatient.Medication = Console.ReadLine();
                        break;
                    case "10" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingPatient.DoctorID = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "11" :
                        keepUpdating = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;          
                }
            }

            bool isSuccess = _patientRepo.Update(existingPatient);
            if(isSuccess)
            {
                Console.WriteLine("Success : Patient Details Updated");
            }
            else
            {
                Console.WriteLine("Failure : Could not update Patient's details.");
            }
        }

        // Deletes a patient record from the repository using the provided ID.
        public void DeleteData()
        {
            Console.Write("Enter the patient id you want to delete : ");
            int patientId = Convert.ToInt32(Console.ReadLine());
            bool isSuccess = _patientRepo.Delete(patientId);
            if (isSuccess)
            {
                Console.WriteLine("Success : Doctor deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Failure : Doctor with the doctor id {patientId} cannot be deleted");
            }
        }
    }
}