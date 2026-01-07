using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.HospitalManagementSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Patient[] hospitalWard = new Patient[]
            {
            new InPatient("P-101", "Sarah Connor", 35, 200.00, 5),
            new OutPatient("P-102", "John Smith", 42, 50.00, 30.00),
            new InPatient("P-103", "Emily Davis", 28, 150.00, 2)
            };
            // Simulating adding records
            if (hospitalWard[0] is IMedicalRecord)
            {
                ((IMedicalRecord)hospitalWard[0]).AddRecord("Acute Appendicitis - Surgery Completed");
            }
            if (hospitalWard[1] is IMedicalRecord)
            {
                ((IMedicalRecord)hospitalWard[1]).AddRecord("Seasonal Flu - Prescribed Antibiotics");
            }
            ProcessPatients(hospitalWard);
        }
        public static void ProcessPatients(Patient[] patients)
        {
            Console.WriteLine("Hospital Patient Billing & Records...\n");
            foreach (Patient patient in patients)
            {
                Console.WriteLine(patient.GetPatientDetails());
                Console.WriteLine("Total Bill: $" + patient.CalculateBill());
                if (patient is IMedicalRecord)
                {
                    ((IMedicalRecord)patient).ViewRecords();
                }
            }
        }
    }
}
