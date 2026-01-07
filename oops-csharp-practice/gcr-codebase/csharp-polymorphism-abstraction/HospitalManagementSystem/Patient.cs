using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.HospitalManagementSystem
{
    internal abstract class Patient
    {
        private string PatientId;
        private string Name;
        private int Age;

        public Patient(string patientId, string name, int age)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
        }

        public string GetPatientId()
        {
            return PatientId;
        }

        public void SetPatientId(string patientId)
        {
            PatientId = patientId;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public string GetPatientDetails()
        {
            return "ID: " + PatientId + " | Name: " + Name + " | Age: " + Age;
        }

        public abstract double CalculateBill();
    }
}
