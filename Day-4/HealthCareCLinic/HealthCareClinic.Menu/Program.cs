using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using HealthCareClinic.Models;
using HealthCareClinic.Controller;
using HealthCareClinic.Services;

namespace HealthCareClinic.Menu
{
    // Summary: Starts the clinic application and initializes services.
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            IHealthCareClinicRepository<Doctor> doctorRepo = new DoctorRepository(connectionString);
            IHealthCareClinicRepository<Patient> patientRepo = new PatientRepository(connectionString);
            IAppointmentRepository<Appointment> appointmentRepo = new AppointmentRepository(connectionString);

            IHealthCareClinicServices doctorService = new DoctorService(doctorRepo);
            IHealthCareClinicServices patientService = new PatientService(patientRepo);
            IHealthCareClinicServices appointmentService = new AppointmentService(appointmentRepo);

            HealthCareClinicMenu menu = new HealthCareClinicMenu(doctorService, patientService, appointmentService);
            
            menu.Start();
        }
    }
}