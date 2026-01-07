using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.HospitalManagementSystem
{
    internal class OutPatient : Patient, IMedicalRecord
    {
        private double ConsultationFee;
        private double MedicineCost;
        private string DiagnosisHistory; // Encapsulated sensitive data

        public OutPatient(string patientId, string name, int age, double consultationFee, double medicineCost)
            : base(patientId, name, age)
        {
            ConsultationFee = consultationFee;
            MedicineCost = medicineCost;
            DiagnosisHistory = "No records yet.";
        }

        public override double CalculateBill()
        {
            return ConsultationFee + MedicineCost;
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
