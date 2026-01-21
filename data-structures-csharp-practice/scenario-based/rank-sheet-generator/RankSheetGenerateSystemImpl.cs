using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.ranksheetgenerator
{
    // Implementation of the System working
    internal class RankSheetGenerateSystemImpl : IRankSheetGeneratorSystem
    {
        // Linked list created to define and store the characteristics of Student
        LinkedList<StudentInformation> Students = new LinkedList<StudentInformation>();
        // Random class used to generate random scores for each student
        static Random StudentScoreGenerator = new Random();
        // Count every student registered in the system
        static int StudentCount;
        // Function to add a student's details to the system
        public void AddAStudentInTheRanks()
        {
            StudentInformation studentInformation = new StudentInformation();
            Console.WriteLine("Give Student Details : ");
            Console.Write("Student Name : ");
            studentInformation.StudentName = Console.ReadLine();
            Console.Write("Student State : ");
            studentInformation.StudentState = Console.ReadLine();
            Console.Write("Student City : ");
            studentInformation.StudentCity = Console.ReadLine();
            Console.Write("Student Id : ");
            studentInformation.StudentId = Console.ReadLine();
            studentInformation.StudentScore = StudentScoreGenerator.Next(1, 101);
            Students.AddLast(studentInformation);
            StudentCount++;
        }
        // Function to generate rank for a student in the system
        public void RankGenetorForTheExam()
        {
            StudentInformation[] studentScores = new StudentInformation[StudentCount];
            int index = 0;
            foreach (StudentInformation student in Students)
            {
                studentScores[index++] = student;
            }
            studentScores = MergeSorting(studentScores,0,StudentCount-1);
            LinkedList<StudentInformation> studentRanks = new LinkedList<StudentInformation>();
            for(int loop = StudentCount - 1; loop > -1 ; loop--)
            {
                studentRanks.AddLast(studentScores[loop]);
            }
            Students = studentRanks;
        }
        // Sorting the students using Merge sorting technique
        public StudentInformation[] MergeSorting(StudentInformation[] studentScores, int left, int right)
        {
            if(left < right)
            {
                int middle = left + (right - left) / 2;
                studentScores = MergeSorting(studentScores, left, middle);
                studentScores = MergeSorting(studentScores, middle+1, right);
                studentScores = Merging(studentScores,left, middle,right);
            }
            return studentScores;
        }
        public StudentInformation[] Merging(StudentInformation[] studentScores, int left, int middle, int right)
        {
            int size1 = middle - left + 1;
            int size2 = right - middle;
            StudentInformation[] students1 = new StudentInformation[size1];
            StudentInformation[] students2 = new StudentInformation[size2];
            Array.Copy(studentScores, left, students1, 0, size1);
            Array.Copy(studentScores, middle + 1, students2, 0, size2);
            int loop1 = 0, loop2 = 0;
            int index = left;
            while (loop1 < size1 && loop2 < size2)
            {
                if (students1[loop1].StudentScore <= students2[loop2].StudentScore)
                {
                    studentScores[index] = students1[loop1];
                    index++;
                    loop1++;
                }
                else
                {
                    studentScores[index] = students2[loop2];
                    index++;
                    loop2++;
                }
            }
            while(loop1 < size1)
            {
                studentScores[index] = students1[loop1];
                loop1++;
                index++;
            }
            while(loop2 < size2)
            {
                studentScores[index] = students2[loop2];
                loop2++;
                index++;
            }
            return studentScores;
        }
        // Display the ranking list of the Exam
        public void DisplayTheRankingList()
        {
            RankGenetorForTheExam();
            int rank = 1;
            foreach(StudentInformation student in Students)
            {
                Console.WriteLine((rank++) + ".\n" + student.ToString());
            }
        }
    }
}
