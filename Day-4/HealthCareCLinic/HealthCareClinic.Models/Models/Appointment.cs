using System.ComponentModel.DataAnnotations;

namespace HealthCareClinic.Models
{
    // Summary: Represents a scheduled clinic appointment and status.
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int? DoctorID { get; set; }
        public int? PatientID { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public TimeSpan? AppointmentTime { get; set; }
        [RegularExpression("^(Pending|Completed|Cancelled)$", ErrorMessage = "Status must be Pending, Completed or Cancelled.")]
        public string CompletionStatus { get; set; }

        // Creates an empty appointment object used when loading data from the database.
        public Appointment()
        {
        }

        // Creates an appointment object with the supplied scheduling details.
        public Appointment(int? doctorID, int? patientID, DateTime appointmentDate, TimeSpan appointmentTime, string completionStatus)
        {
            DoctorID = doctorID;
            PatientID = patientID;
            AppointmentDate = appointmentDate;
            AppointmentTime = appointmentTime;
            CompletionStatus = completionStatus;
        }
    }
}