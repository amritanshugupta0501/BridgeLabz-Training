using System;
using HealthCareClinic.Services;

namespace HealthCareClinic.Menu
{
    // Summary: Controls the main console menu for clinic management actions.
    public sealed class HealthCareClinicMenu
    {
        private readonly IHealthCareClinicServices _doctorService;
        private readonly IHealthCareClinicServices _patientService;
        private readonly IHealthCareClinicServices _appointmentService;

        public HealthCareClinicMenu(IHealthCareClinicServices doctorService, IHealthCareClinicServices patientService, IHealthCareClinicServices appointmentService)
        {
            _doctorService = doctorService;
            _patientService = patientService;
            _appointmentService = appointmentService;
        }

        // Starts the main application loop and shows the top-level menu.
        public void Start()
        {
            Console.WriteLine("WELCOME TO HEALTHCARE CLINIC SYSTEM");
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("1. Manage Doctors");
                Console.WriteLine("2. Manage Patients");
                Console.WriteLine("3. Manage Appointments");
                Console.WriteLine("4. Exit Application");
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        DoctorMenu();
                        break;
                    case "2":
                        PatientMenu();
                        break;
                    case "3":
                        AppointmentMenu();
                        break;
                    case "4":
                        exitApp = true;
                        Console.WriteLine("Exiting application. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to try again.");
                        break;
                }
            }
        }
        private void DoctorMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.Clear();
                Console.WriteLine("DOCTOR MANAGEMENT");
                Console.WriteLine("1. Add New Doctor");
                Console.WriteLine("2. View All Doctors");
                Console.WriteLine("3. Search Doctor by ID");
                Console.WriteLine("4. Update Doctor");
                Console.WriteLine("5. Delete Doctor");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                         _doctorService.AddDetails(); 
                         break;
                    case "2": 
                        _doctorService.DisplayAll(); 
                        break;
                    case "3": 
                        _doctorService.DisplayById(); 
                        break;
                    case "4": 
                        _doctorService.UpdateDetails(); 
                        break;
                    case "5": 
                        _doctorService.DeleteData(); 
                        break;
                    case "0": 
                        back = true; 
                        break;
                    default: 
                        Console.WriteLine("Invalid choice."); 
                        break;
                }
            }
        }

        private void PatientMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("PATIENT MANAGEMENT");
                Console.WriteLine("1. Add New Patient");
                Console.WriteLine("2. View All Patients");
                Console.WriteLine("3. Search Patient by ID");
                Console.WriteLine("4. Update Patient");
                Console.WriteLine("5. Delete Patient");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": 
                        _patientService.AddDetails(); 
                        break;
                    case "2": 
                        _patientService.DisplayAll(); 
                        break;
                    case "3":
                        _patientService.DisplayById(); 
                        break;
                    case "4": 
                        _patientService.UpdateDetails(); 
                        break;
                    case "5": 
                        _patientService.DeleteData(); 
                        break;
                    case "0": 
                        back = true; 
                        break;
                    default: 
                        Console.WriteLine("Invalid choice."); 
                        break;
                }
            }
        }

        private void AppointmentMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("APPOINTMENT MANAGEMENT");
                Console.WriteLine("1. Schedule New Appointment");
                Console.WriteLine("2. View All Appointments");
                Console.WriteLine("3. Search/View Appointments");
                Console.WriteLine("4. Update Appointment");
                Console.WriteLine("5. Delete/Cancel Appointment");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": 
                        _appointmentService.AddDetails(); 
                        break;
                    case "2": 
                        _appointmentService.DisplayAll(); 
                        break;
                    case "3": 
                        _appointmentService.DisplayById(); 
                        break;
                    case "4": 
                        _appointmentService.UpdateDetails(); 
                        break;
                    case "5": 
                        _appointmentService.DeleteData(); 
                        break;
                    case "0": 
                        back = true; 
                        break;
                    default: 
                        Console.WriteLine("Invalid choice."); 
                        break;
                }
            }
        }
    }
}