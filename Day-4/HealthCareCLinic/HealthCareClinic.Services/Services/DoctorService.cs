using System;
using System.Collections.Generic;
using HealthCareClinic.Models;
using HealthCareClinic.Controller;

namespace HealthCareClinic.Services
{
    // Summary: Contains business logic for managing doctor data.
    public class DoctorService : IHealthCareClinicServices
    {
        private readonly IHealthCareClinicRepository<Doctor> _doctorRepo;

        public DoctorService(IHealthCareClinicRepository<Doctor> doctorRepo)
        {
            _doctorRepo = doctorRepo;
        }

        // Collects doctor details from the user and stores the new record.
        public void AddDetails()
        {
            Console.WriteLine("Give Doctor Details : ");
            Console.Write("First Name : ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name : ");
            string lastName = Console.ReadLine();
            Console.Write("Specialization : ");
            string specialization = Console.ReadLine();
            Console.Write("Contact Number : ");
            string contactNumber = Console.ReadLine();
            Console.Write("Contact Email : ");
            string contactEmail = Console.ReadLine();
            Console.Write("Room Number : ");
            int roomNumber = Convert.ToInt32(Console.ReadLine());
            Doctor doctor = new Doctor(firstName, lastName, specialization, contactNumber, contactEmail, roomNumber);
            bool isSuccess = _doctorRepo.Add(doctor);
            if (isSuccess)
            {
                Console.WriteLine("Success : Doctor inserted successfully");
            }
            else
            {
                Console.WriteLine("Failure : Could not add doctor, either room is occupied or data is invalid");
            }
        }

        // Displays every doctor record stored in the repository.
        public void DisplayAll()
        {
            Console.WriteLine("List of all Doctors");
            var doctors = _doctorRepo.GetAllData();
            if (doctors == null || doctors.Count == 0)
            {
                Console.WriteLine("No Doctors exist in the database");
            }
            else
            {
                foreach (var doctor in doctors)
                {
                    Console.WriteLine($"Doctor ID : {doctor.DoctorID}");
                    Console.WriteLine($"First Name : {doctor.FirstName}");
                    Console.WriteLine($"Last Name : {doctor.LastName}");
                    Console.WriteLine($"Specialization : {doctor.Specialization}");
                    Console.WriteLine($"Contact Number : {doctor.ContactNumber}");
                    Console.WriteLine($"Contact Email: {doctor.ContactEmail}");
                    Console.WriteLine($"Room Number : {doctor.RoomNumber}");
                    Console.WriteLine();
                }
            }
        }

        // Searches for and displays a single doctor by their ID.
        public void DisplayById()
        {
            Console.Write("Give the Doctor ID to search : ");
            int doctorID = Convert.ToInt32(Console.ReadLine());
            var doctor = _doctorRepo.GetDataById(doctorID);
            if (doctor == null)
            {
                Console.WriteLine("No doctor with the given id");
            }
            else
            {
                Console.WriteLine($"Doctor ID : {doctor.DoctorID}");
                Console.WriteLine($"First Name : {doctor.FirstName}");
                Console.WriteLine($"Last Name : {doctor.LastName}");
                Console.WriteLine($"Specialization : {doctor.Specialization}");
                Console.WriteLine($"Contact Number : {doctor.ContactNumber}");
                Console.WriteLine($"Contact Email: {doctor.ContactEmail}");
                Console.WriteLine($"Room Number : {doctor.RoomNumber}");
                Console.WriteLine();
            }
        }

        // Updates the selected doctor profile through an interactive menu.
        public void UpdateDetails()
        {
            Console.WriteLine("Enter the Doctor you want to update : ");
            int doctorID = Convert.ToInt32(Console.ReadLine());
            Doctor existingDoctor = _doctorRepo.GetDataById(doctorID);
            if (existingDoctor == null)
            {
                Console.WriteLine("Failure : No doctor with the given Id");
                return;
            }

            bool keepUpdating = true;
            while (keepUpdating)
            {
                Console.WriteLine($"Updating Doctor {existingDoctor.FirstName} {existingDoctor.LastName}");
                Console.WriteLine("1. Update First Name");
                Console.WriteLine("2. Update Last Name");
                Console.WriteLine("3. Update Specialization");
                Console.WriteLine("4. Update Contact Number");
                Console.WriteLine("5. Update Contact Email");
                Console.WriteLine("6. Update Room Number");
                Console.WriteLine("7. Save Updates");
                Console.WriteLine("Choose details to update.");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingDoctor.FirstName = Console.ReadLine();
                        break;
                    case "2" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingDoctor.LastName = Console.ReadLine();
                        break;
                    case "3" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingDoctor.Specialization = Console.ReadLine();
                        break;
                    case "4" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingDoctor.ContactNumber = Console.ReadLine();
                        break;
                    case "5" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingDoctor.ContactEmail = Console.ReadLine();
                        break;
                    case "6" :
                        Console.WriteLine("Enter the updated detail : ");
                        existingDoctor.RoomNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "7" :
                        keepUpdating = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                            
                }
            }

            bool isSuccess = _doctorRepo.Update(existingDoctor);
            if(isSuccess)
            {
                Console.WriteLine("Success : Doctor Details Updated");
            }
            else
            {
                Console.WriteLine("Failure : Could not update Doctor's details.");
            }
        }

        // Deletes a doctor record from the repository using the provided ID.
        public void DeleteData()
        {
            Console.Write("Enter the doctor id you want to delete : ");
            int doctorId = Convert.ToInt32(Console.ReadLine());
            bool isSuccess = _doctorRepo.Delete(doctorId);
            if (isSuccess)
            {
                Console.WriteLine("Success : Doctor deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Failure : Doctor with the doctor id {doctorId} cannot be deleted");
            }
        }
    }
}