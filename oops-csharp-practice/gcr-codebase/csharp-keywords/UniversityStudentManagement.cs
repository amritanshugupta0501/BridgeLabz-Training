using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpkeywords
{
    internal class UniversityStudentManagement
    {
        public static string UniversityName = "Global Education Institute";
        private static int totalStudents = 0;
        public readonly int rollNumber;
        public string studentName;
        public string studentGrade;
        public UniversityStudentManagement(int rollNumber, string studentName, string studentGrade)                 // Constructor defined to get characteristics of students
        {
            this.studentName = studentName;
            this.rollNumber = rollNumber;
            this.studentGrade = studentGrade;
            totalStudents++;
        }
        public static void DisplayTotalStudents()                                                                   // Display totall students in the university
        {
            Console.WriteLine("Total students in the university : "+totalStudents);
        }
        public void UpdateGrade(string grade)                                                                       // Function to update grades of the student
        {
            studentGrade = grade;
            Console.WriteLine("Grade updated for "+studentName+". New Grade : "+studentGrade);
        }
        public void DisplayStudentDetails()                                                                         // Display the details of the students
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Student Name : "+studentName);
            Console.WriteLine("Student Roll Number : "+rollNumber);
            Console.WriteLine("Student Grade : "+studentGrade);
        }
    }
    class Program
    {
        static void Main()                                                                                          // Entry point of the application
        {
            Console.WriteLine("Give Student Details : ");
            Console.Write("Give student roll number : ");
            int rollNumber = int.Parse(Console.ReadLine());
            Console.Write("Give student name : ");
            string name = Console.ReadLine();
            Console.Write("Give student grade : ");
            string grade = Console.ReadLine();
            UniversityStudentManagement student = new UniversityStudentManagement(rollNumber, name, grade);         // Constructor called
            if(student is UniversityStudentManagement)                                                              // Checking the type of object using 'is' operator
            {
                student.DisplayStudentDetails();
                student.UpdateGrade("B-");
            }
            else
            {
                Console.WriteLine("Invalid Object.");
            }
            UniversityStudentManagement.DisplayTotalStudents();
        }
    }
}
