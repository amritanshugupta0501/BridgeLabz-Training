using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using HealthCareClinic.Models;

namespace HealthCareClinic.Controller
{
    // Summary: Handles database operations for patient records.
    public class PatientRepository : IHealthCareClinicRepository<Patient>
    {
        private readonly string _connectionString;

        public PatientRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Adds a new patient by calling the stored procedure for patient insertion.
        public bool Add(Patient patient)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddPatient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    command.Parameters.AddWithValue("@LastName", patient.LastName);
                    command.Parameters.AddWithValue("@Gender", patient.Gender);
                    command.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                    command.Parameters.AddWithValue("@ContactNumber", patient.ContactNumber);
                    command.Parameters.AddWithValue("@ContactEmail", patient.ContactEmail);
                    command.Parameters.AddWithValue("@ResidenceAddress", patient.ResidenceAddress);
                    command.Parameters.AddWithValue("@MedicalDescription", patient.MedicalDescription);
                    command.Parameters.AddWithValue("@Medication", patient.Medication);
                    command.Parameters.AddWithValue("@DoctorID", patient.DoctorID.HasValue ? (object)patient.DoctorID.Value : DBNull.Value);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        // Retrieves all patients from the database.
        public List<Patient> GetAllData()
        {
            List<Patient> patients = new List<Patient>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetPatients", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patients.Add(new Patient
                            {
                                PatientID = Convert.ToInt32(reader["PatientID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Gender = Convert.ToChar(reader["Gender"]),
                                DateOfBirth = reader["DateOfBirth"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                                ContactEmail = reader["ContactEmail"].ToString(),
                                ResidenceAddress = reader["ResidenceAddress"].ToString(),
                                MedicalDescription = reader["MedicalDescription"].ToString(),
                                Medication = reader["Medication"].ToString(),
                                DoctorID = Convert.ToInt32(reader["DoctorID"])
                            });
                        }
                    }
                }
            }
            return patients;
        }
        // Retrieves a single patient record using the provided patient ID.
        public Patient GetDataById(int patientID)
        {
            Patient patient = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetPatientById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            patient = new Patient
                            {
                                PatientID = Convert.ToInt32(reader["PatientID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Gender = Convert.ToChar(reader["Gender"]),
                                DateOfBirth = reader["DateOfBirth"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                                ContactEmail = reader["ContactEmail"].ToString(),
                                ResidenceAddress = reader["ResidenceAddress"].ToString(),
                                MedicalDescription = reader["MedicalDescription"].ToString(),
                                Medication = reader["Medication"].ToString(),
                                DoctorID = Convert.ToInt32(reader["DoctorID"])
                            };
                        }
                    }
                }
            }
            return patient;
        }
        // Updates an existing patient record in the database.
        public bool Update(Patient patient)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdatePatient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("PatientID", patient.PatientID);
                    command.Parameters.AddWithValue("FirstName", string.IsNullOrEmpty(patient.FirstName) ? DBNull.Value : patient.FirstName);
                    command.Parameters.AddWithValue("@LastName", string.IsNullOrEmpty(patient.LastName) ? DBNull.Value : patient.LastName);
                    command.Parameters.AddWithValue("@Gender", patient.Gender == '\0' ? DBNull.Value : patient.Gender);
                    command.Parameters.AddWithValue("@DateOfBirth", string.IsNullOrEmpty(patient.DateOfBirth) ? DBNull.Value : patient.DateOfBirth);
                    command.Parameters.AddWithValue("@ContactNumber", string.IsNullOrEmpty(patient.ContactNumber) ? DBNull.Value : patient.ContactNumber);
                    command.Parameters.AddWithValue("@ContactEmail", string.IsNullOrEmpty(patient.ContactEmail) ? DBNull.Value : patient.ContactEmail);
                    command.Parameters.AddWithValue("@ResidenceAddress", string.IsNullOrEmpty(patient.ResidenceAddress) ? DBNull.Value : patient.ResidenceAddress);
                    command.Parameters.AddWithValue("@MedicalDescription", string.IsNullOrEmpty(patient.MedicalDescription) ? DBNull.Value : patient.MedicalDescription);
                    command.Parameters.AddWithValue("@Medication", string.IsNullOrEmpty(patient.Medication) ? DBNull.Value : patient.Medication);
                    command.Parameters.AddWithValue("@DoctorID", patient.DoctorID.HasValue ? (object)patient.DoctorID.Value : DBNull.Value);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        // Deletes a patient record from the database using the supplied ID.
        public bool Delete(int patientID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeletePatient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientID", patientID);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
