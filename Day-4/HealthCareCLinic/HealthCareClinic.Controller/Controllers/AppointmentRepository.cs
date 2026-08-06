using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using HealthCareClinic.Models;

namespace HealthCareClinic.Controller
{
    // Summary: Handles database operations for appointment records.
    public class AppointmentRepository : IAppointmentRepository<Appointment>
    {
        private readonly string _connectionString;

        public AppointmentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Schedules a new appointment by invoking the stored procedure.
        public bool Add(Appointment appointment)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddAppointment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                    command.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                    command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                    command.Parameters.AddWithValue("@AppointmentTime", appointment.AppointmentTime);
                    command.Parameters.AddWithValue("@CompletionStatus", appointment.CompletionStatus);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        // Retrieves all appointments from the database.
        public List<Appointment> GetAllAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAppointments", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointments.Add(new Appointment
                            {
                                AppointmentID = Convert.ToInt32(reader["AppointmentID"]),
                                DoctorID = Convert.ToInt32(reader["DoctorID"]),
                                PatientID = Convert.ToInt32(reader["PatientID"]),
                                AppointmentDate = Convert.ToDateTime(reader["AppointmentDate"]),
                                AppointmentTime = (TimeSpan)reader["AppointmentTime"],
                                CompletionStatus = reader["CompletionStatus"].ToString()
                            });
                        }
                    }
                }
            }
            return appointments;
        }
        // Retrieves appointments by applying the provided filter values such as patient, doctor, or appointment ID.
        public List<Appointment> GetAppointmentByFilter(int? patientId = null, int? doctorId = null, int? appointmentid = null)
        {
            List<Appointment> appointments = new List<Appointment>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAppointmentById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("PatientID", patientId.HasValue ? (object)patientId.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@DoctorID", doctorId.HasValue ? (object)doctorId.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@AppointmentID", appointmentid.HasValue ? (object)appointmentid.Value : DBNull.Value);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointments.Add(new Appointment
                            {
                                AppointmentID = Convert.ToInt32(reader["AppointmentID"]),
                                DoctorID = Convert.ToInt32(reader["DoctorID"]),
                                PatientID = Convert.ToInt32(reader["PatientID"]),
                                AppointmentDate = Convert.ToDateTime(reader["AppointmentDate"]),
                                AppointmentTime = (TimeSpan)reader["AppointmentTime"],
                                CompletionStatus = reader["CompletionStatus"].ToString()
                            });
                        }
                    }
                }
            }
            return appointments;
        }
        // Updates an existing appointment record in the database.
        public bool Update(Appointment appointment)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateAppointment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AppointmentID", appointment.AppointmentID);
                    command.Parameters.AddWithValue("@PatientID", appointment.PatientID.HasValue ? (object)appointment.PatientID.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@DoctorID", appointment.DoctorID.HasValue ? (object)appointment.DoctorID.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate.HasValue ? (object)appointment.AppointmentDate.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@AppointmentTime", appointment.AppointmentTime.HasValue ? (object)appointment.AppointmentTime.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@CompletionStatus", string.IsNullOrEmpty(appointment.CompletionStatus) ? DBNull.Value : appointment.CompletionStatus);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        // Deletes an appointment record from the database using the supplied ID.
        public bool Delete(int appointmentId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteAppointment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AppointmentID", appointmentId);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}