using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpkeywords
{
    internal class HospitalManagementSystem
    {
        public static string hospitalName = "General Hospital";
        private static int totalPatients = 0;
        public readonly int patientId;
        public string patientName;
        public string ailment;
        public int patientAge;
        public HospitalManagementSystem(int patientId, string patientName, string ailment, int patientAge)          // Constructor defined to define all the attributes of a patient
        {
            this.patientId = patientId;
            this.patientName = patientName;
            this.ailment = ailment;
            this.patientAge = patientAge;
            totalPatients++;
        }
        public static int GetTotalPatients()                                                                        // Function to display all the patients in a hospital
        {
            return totalPatients;
        }
        public void DisplayPatientDetails()                                                                         // Function to display all the details of a patient
        {
            Console.WriteLine("Patient Record");
            Console.WriteLine("Hospital Name : "+hospitalName);
            Console.WriteLine("Patient's Name : "+patientName);
            Console.WriteLine("Patient's Id : "+patientId);
            Console.WriteLine("Patient's Ailment : "+ailment);
            Console.WriteLine("Patient's Age : "+patientAge);
        }
    }
    class Program
    {
        static void Main()                                                                                              // Entry point program of the application
        {
            Console.WriteLine("Give Patient Details : ");
            Console.Write("Patient's Name : ");
            string name = Console.ReadLine();
            Console.Write("Patient's Id : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Patient's Ailment : ");
            string ailment = Console.ReadLine();
            Console.Write("Patient's Age : ");
            int age = int.Parse(Console.ReadLine());
            HospitalManagementSystem patient = new HospitalManagementSystem(id, name, ailment, age);                    // Constructor called to get attributes of a patient
            if (patient is HospitalManagementSystem)                                                                    // Checking the type of object using 'is' operator
            {
                patient.DisplayPatientDetails();
            }
            else
            {
                Console.WriteLine("Invalid Object.");
            }
            Console.WriteLine("Total patients admitted : "+HospitalManagementSystem.GetTotalPatients());
        }
    }
}
