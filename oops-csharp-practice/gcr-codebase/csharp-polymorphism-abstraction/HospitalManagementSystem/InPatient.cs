using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.HospitalManagementSystem
{
    internal class InPatient : Patient, IMedicalRecord
    {
        private double DailyRate;
        private int DaysAdmitted;
        private string DiagnosisHistory; // Encapsulated sensitive data

        public InPatient(string patientId, string name, int age, double dailyRate, int daysAdmitted)
            : base(patientId, name, age)
        {
            DailyRate = dailyRate;
            DaysAdmitted = daysAdmitted;
            DiagnosisHistory = "No records yet.";
        }

        public override double CalculateBill()
        {
            return DailyRate * DaysAdmitted;
        }

        public void AddRecord(string diagnosis)
        {
            DiagnosisHistory = diagnosis;
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical History (Confidential): " + DiagnosisHistory);
        }
    }
}
