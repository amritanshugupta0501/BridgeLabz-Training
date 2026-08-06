using System;
using HealthCareClinic.Models;
using HealthCareClinic.Controller;

namespace HealthCareClinic.Services
{
    // Summary: Contains business logic for scheduling and managing appointments.
    public class AppointmentService : IHealthCareClinicServices
    {
        private readonly IAppointmentRepository<Appointment> _appointmentRepo;

        public AppointmentService(IAppointmentRepository<Appointment> appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        // Schedules a new appointment using details provided by the user.
        public void AddDetails()
        {
            Console.WriteLine("Schedule New Appointment : ");
            Console.Write("Enter Patient ID: ");
            int patientId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Doctor ID: ");
            int doctorId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Date (YYYY-MM-DD): ");
            DateTime appointmentDate = DateTime.Parse(Console.ReadLine());
  
            Console.Write("Enter Time (HH:MM): ");
            TimeSpan appointmentTime = TimeSpan.Parse(Console.ReadLine());
  
            Console.Write("Enter Status (Scheduled/Completed/Cancelled): ");
            string completionStatus = Console.ReadLine();

            Appointment appointment =
                new Appointment(doctorId, patientId, appointmentDate, appointmentTime, completionStatus);
            bool isSuccess = _appointmentRepo.Add(appointment);
            if (isSuccess)
            {
                Console.WriteLine("Success : Appointment scheduled!");
            }
            else
            {
                Console.WriteLine("Failure : Verify if Patient and Doctor IDs exist.");
            }
        }

        // Displays every appointment currently stored in the repository.
        public void DisplayAll()
        {
            var appts = _appointmentRepo.GetAllAppointments();
            if (appts == null || appts.Count == 0)
            {
                Console.WriteLine("No appointments found."); return;
            }
            foreach (var a in appts)
            {
                Console.WriteLine($"Appt ID: {a.AppointmentID} | Patient: {a.PatientID} | Doctor: {a.DoctorID} | Date: {a.AppointmentDate?.ToString("yyyy-MM-dd")} {a.AppointmentTime} | Status: {a.CompletionStatus}");
            }
        }

        // Searches for appointments using a selected filter such as patient, doctor, or appointment ID.
        public void DisplayById()
        {
            Console.WriteLine("How would you like to find the appointment(s)?");
            Console.WriteLine("1. Search by Patient ID");
            Console.WriteLine("2. Search by Doctor ID");
            Console.WriteLine("3. Search by Appointment ID");
            string searchChoice = Console.ReadLine();
            List<Appointment> searchResults = new List<Appointment>();
            if (searchChoice == "1")
            {
                Console.Write("Enter Patient ID: ");
                if (int.TryParse(Console.ReadLine() ?? "", out int pId))
                {
                    searchResults = _appointmentRepo.GetAppointmentByFilter(patientId: pId);
                }
            }
            else if (searchChoice == "2")
            {
                Console.Write("Enter Doctor ID: ");
                if (int.TryParse(Console.ReadLine() ?? "", out int dId))
                {
                    searchResults = _appointmentRepo.GetAppointmentByFilter(doctorId: dId);
                }
            }
            else if (searchChoice == "3")
            {
                Console.Write("Enter Appointment ID: ");
                if (int.TryParse(Console.ReadLine() ?? "", out int aId))
                {
                    searchResults = _appointmentRepo.GetAppointmentByFilter(appointmentid: aId);
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Returning to menu.");
                return;
            }
            if (searchResults == null || searchResults.Count == 0)
            {
                Console.WriteLine("No appointments found matching your search.");
                return;
            }

            Console.WriteLine($"Found {searchResults.Count} Appointment(s)");
            foreach (var a in searchResults)
            {
                Console.WriteLine($"Appointment ID: {a.AppointmentID}");
                Console.WriteLine($"Date:           {a.AppointmentDate?.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Time:           {a.AppointmentTime}");
                Console.WriteLine($"Patient ID:     {a.PatientID}");
                Console.WriteLine($"Doctor ID:      {a.DoctorID}");
                Console.WriteLine($"Status:         {a.CompletionStatus}");
            }
        }
        // Updates an existing appointment after locating it through the user-selected search option.
        public void UpdateDetails()
        {
            Console.WriteLine("How would you like to find the appointment?");
            Console.WriteLine("1. Search by Patient ID");
            Console.WriteLine("2. Search by Doctor ID");
            Console.WriteLine("3. I already know the Appointment ID");
            Console.Write("Choice (1-3): ");
            string searchChoice = Console.ReadLine() ?? "";
            List<Appointment> searchResults = new List<Appointment>();
            if (searchChoice == "1")
            {
                Console.Write("Enter Patient ID: ");
                if (int.TryParse(Console.ReadLine() ?? "", out int pId))
                {
                    searchResults = _appointmentRepo.GetAppointmentByFilter(patientId: pId);
                }
            }
            else if (searchChoice == "2")
            {
            Console.Write("Enter Doctor ID: ");
            if (int.TryParse(Console.ReadLine() ?? "", out int dId))
            searchResults = _appointmentRepo.GetAppointmentByFilter(doctorId: dId);
            }
            else if (searchChoice == "3")
            {
                Console.Write("Enter Appointment ID: ");
                if (int.TryParse(Console.ReadLine() ?? "", out int aId))
                {
                    searchResults = _appointmentRepo.GetAppointmentByFilter(appointmentid: aId);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Returning to menu.");
                    return;
                }

                if (searchResults == null || searchResults.Count == 0)
                {
                    Console.WriteLine("No appointments found matching your search.");
                    return;
                }

                Console.WriteLine("Found Appointments : ");
                foreach (var appt in searchResults)
                {
                    Console.WriteLine(
                        $"[Appt ID: {appt.AppointmentID}] - Date: {appt.AppointmentDate?.ToString("yyyy-MM-dd")} {appt.AppointmentTime} | Patient: {appt.PatientID} | Doctor: {appt.DoctorID} | Status: {appt.CompletionStatus}");
                }

                Console.Write("\nEnter the Appointment ID you want to update from the list above: ");
                string idInput = Console.ReadLine() ?? "";
                if (!int.TryParse(idInput, out int appointmentId))
                {
                    Console.WriteLine("Invalid ID format.");
                    return;
                }

                Appointment a = searchResults.Find(x => x.AppointmentID == appointmentId);

                if (a == null)
                {
                    Console.WriteLine($"FAILED: You selected an ID that wasn't in the list.");
                    return;
                }

                bool keepUpdating = true;
                while (keepUpdating)
                {
                    Console.WriteLine($"\n--- Updating Appt ID: {a.AppointmentID} ---");
                    Console.WriteLine("1. Patient ID");
                    Console.WriteLine("2. Doctor ID");
                    Console.WriteLine("3. Date");
                    Console.WriteLine("4. Time");
                    Console.WriteLine("5. Status");
                    Console.WriteLine("6. SAVE & EXIT");
                    Console.Write("Choose (1-6): ");

                    string choice = Console.ReadLine() ?? "";
                    switch (choice)
                    {
                        case "1":
                            Console.Write($"Patient ID ({a.PatientID}): ");
                            string pInput = Console.ReadLine() ?? "";
                            if (int.TryParse(pInput, out int p))
                            {
                                a.PatientID = p;
                            }

                            break;
                        case "2":
                            Console.Write($"Doctor ID ({a.DoctorID}): ");
                            string dInput = Console.ReadLine() ?? "";
                            if (int.TryParse(dInput, out int d))
                            {
                                a.DoctorID = d;
                            }

                            break;
                        case "3":
                            Console.Write($"Date ({a.AppointmentDate?.ToString("yyyy-MM-dd")}): ");
                            string dateInput = Console.ReadLine() ?? "";
                            if (DateTime.TryParse(dateInput, out DateTime dt))
                            {
                                a.AppointmentDate = dt;
                            }

                            break;
                        case "4":
                            Console.Write($"Time ({a.AppointmentTime}): ");
                            string timeInput = Console.ReadLine() ?? "";
                            if (TimeSpan.TryParse(timeInput, out TimeSpan ts))
                            {
                                a.AppointmentTime = ts;
                            }

                            break;
                        case "5":
                            Console.Write($"Status ({a.CompletionStatus}): ");
                            a.CompletionStatus = Console.ReadLine() ?? "";
                            break;
                        case "6":
                            keepUpdating = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }

                bool isSuccess = _appointmentRepo.Update(a);

                if (isSuccess)
                {
                    Console.WriteLine($"SUCCESS: Appointment {appointmentId} updated!");
                }
                else
                {
                    Console.WriteLine("FAILED: Update failed. Please check if Doctor/Patient IDs exist.");
                }
            }
        }
        // Deletes or cancels an appointment using the provided appointment ID.
        public void DeleteData()
        {
            Console.Write("Enter Appointment ID to cancel/delete: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                return;
            }
            bool isSuccess = _appointmentRepo.Delete(id);
            if (isSuccess)
            {
                Console.WriteLine("Success: Appointment deleted.");
            }
            else
            {
                Console.WriteLine("Failure: Appointment could not be deleted.");
            }
        }
    }
}