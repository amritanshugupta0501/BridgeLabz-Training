using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using HealthCareClinic.Models;

namespace HealthCareClinic.Controller
{
    // Summary: Handles database operations for doctor records.
    public class DoctorRepository : IHealthCareClinicRepository<Doctor>
    {
        private readonly string _connectionString;

        public DoctorRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Adds a new doctor by calling the stored procedure for doctor insertion.
        public bool Add(Doctor doctor)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddDoctor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                    command.Parameters.AddWithValue("@LastName", doctor.LastName);
                    command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                    command.Parameters.AddWithValue("@ContactNumber", doctor.ContactNumber);
                    command.Parameters.AddWithValue("@ContactEmail", doctor.ContactEmail);
                    command.Parameters.AddWithValue("@RoomNumber", doctor.RoomNumber);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        // Retrieves all doctors from the database.
        public List<Doctor> GetAllData()
        {
            List<Doctor> doctors = new List<Doctor>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetDoctors", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctors.Add(new Doctor
                            {
                                DoctorID = Convert.ToInt32(reader["DoctorID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Specialization = reader["Specialization"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                                ContactEmail = reader["ContactEmail"].ToString(),
                                RoomNumber = Convert.ToInt32(reader["RoomNumber"])
                            });
                        }
                    }
                }
            }
            return doctors;
        }
        // Retrieves a single doctor record using the provided doctor ID.
        public Doctor GetDataById(int doctorId)
        {
            Doctor doctor = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetDoctorById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            doctor = new Doctor
                            {
                                DoctorID = Convert.ToInt32(reader["DoctorID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Specialization = reader["Specialization"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                                ContactEmail = reader["ContactEmail"].ToString(),
                                RoomNumber = Convert.ToInt32(reader["RoomNumber"])
                            };
                        }
                    }
                }
            }
            return doctor;
        }
        // Updates an existing doctor record in the database.
        public bool Update(Doctor doctor)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateDoctor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DoctorID", doctor.DoctorID);
                    command.Parameters.AddWithValue("@FirstName", string.IsNullOrEmpty(doctor.FirstName) ? DBNull.Value : doctor.FirstName);
                    command.Parameters.AddWithValue("@LastName", string.IsNullOrEmpty(doctor.LastName) ? DBNull.Value : doctor.LastName);
                    command.Parameters.AddWithValue("@Specialization", string.IsNullOrEmpty(doctor.Specialization) ? DBNull.Value : doctor.Specialization);
                    command.Parameters.AddWithValue("@ContactNumber", string.IsNullOrEmpty(doctor.ContactNumber) ? DBNull.Value : doctor.ContactNumber);
                    command.Parameters.AddWithValue("@ContactEmail", string.IsNullOrEmpty(doctor.ContactEmail) ? DBNull.Value : doctor.ContactEmail);
                    command.Parameters.AddWithValue("@RoomNumber", doctor.RoomNumber == 0 ? DBNull.Value : doctor.RoomNumber);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        // Deletes a doctor record from the database using the supplied ID.
        public bool Delete(int doctorId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteDoctor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DoctorID", doctorId);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}