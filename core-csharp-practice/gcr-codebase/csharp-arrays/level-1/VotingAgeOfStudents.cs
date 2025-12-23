using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Find the students who can vote or not based on their ages
 internal class VotingAgeOfStudents
    {
        static void Main()
        {
            int[] ageOfStudents = new int[10];
            for(int loop = 0; loop < ageOfStudents.Length; loop++)				// Input ages of students from the user
            {
                Console.WriteLine("Enter the age of the student : ");
                ageOfStudents[loop] = int.Parse(Console.ReadLine());
            }
            for(int loop = 0; loop < ageOfStudents.Length; loop++)				// Initiate a loop to traverse through the ages of students
            {
                if (ageOfStudents[loop] >= 18)							// Determine whether a student can vote or not
                {
                    Console.WriteLine("The student with the age " + ageOfStudents[loop] + " can vote.");
                }
                else
                {
                    Console.WriteLine("The student with the age " + ageOfStudents[loop] + " cannot vote.");
                }
            }
        }
    }
