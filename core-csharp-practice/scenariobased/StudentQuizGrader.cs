using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased
{
    internal class StudentQuizGrader
    {
        static void Main()
        {
            StudentQuizGrader quizGrader = new StudentQuizGrader();
            quizGrader.SystemInitialize();
        }
        void SystemInitialize()
        {
            long adminPassword = SetAdminPassword();
            long studentPassword = SetStudentPassword();
            int questions = GetNumberOfQuestions(adminPassword);
            if (questions == 0) 
            {
                Console.WriteLine("Only the admin can access the application.");
                return;
            }
            string[] correctAnswers = GiveCorrectAnswers(adminPassword,questions);
            if(correctAnswers[0] ==null)
            {
                return;
            }
            string[] studentAnswers = GiveStudentAnswers(studentPassword, questions);
            if (studentAnswers[0] == null)
            {
                return;
            }
            int numberOfCorrectAnswers = GetStudentScore(correctAnswers, studentAnswers);
            double percentage = numberOfCorrectAnswers / questions;
            DisplayResult(percentage);
        }
        void DisplayResult(double percentage)
        {
            Console.WriteLine("Student Percentage : " + percentage);
            if (percentage >= 40)
            {
                Console.WriteLine("The student has passed.");
            }
            else
            {
                Console.WriteLine("The student has failed.");
            }
        }
        long SetAdminPassword()
        {
            Console.WriteLine("Set the admin password : ");
            long password = long.Parse(Console.ReadLine());
            return password;
        }
        long SetStudentPassword()
        {
            Console.WriteLine("Set the student password : ");
            long password = long.Parse(Console.ReadLine());
            return password;
        }
        bool CheckAdmin(long adminPassword)
        {
            Console.WriteLine("Enter Admin Password : ");
            long password = long.Parse(Console.ReadLine());
            return password == adminPassword;
        }
        bool CheckStudent(long studentPassword)
        {
            Console.WriteLine("Enter Student Password : ");
            long password = long.Parse(Console.ReadLine());
            return password == studentPassword;
        }
        int GetNumberOfQuestions(long adminPassword)
        {
            if(CheckAdmin(adminPassword))
            {
                Console.WriteLine("Give the number of questions for the quiz : ");
                int questions = int.Parse(Console.ReadLine());
                return questions;
            }
            return 0;
        }
        string[] GiveCorrectAnswers(long adminPassword, int questions)
        {
            string[] correctAnswers = new string[questions];
            if (CheckAdmin(adminPassword))
            {
                for (int loop = 0; loop < questions; loop++)
                {
                    Console.Write("Give answer to question number " + (loop + 1) + " : ");
                    correctAnswers[loop] = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("You are not given the admin access to the application.");
            }
            return correctAnswers;
        }
        string[] GiveStudentAnswers(long studentPassword, int questions)
        {
            string[] correctAnswers = new string[questions];
            if (CheckStudent(studentPassword))
            {
                for (int loop = 0; loop < questions; loop++)
                {
                    Console.Write("Give answer to question number " + (loop + 1) + " : ");
                    correctAnswers[loop] = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("You are not given the student access to the application.");
            }
            return correctAnswers;
        }
        int GetStudentScore(string[] correctAnswers, string[] studentAnswers)
        {
            int score = 0;
            for (int loop = 0; loop < correctAnswers.Length;loop++)
            {
                Console.Write("Question " + (loop + 1) + " : ");
                if (correctAnswers[loop].ToLower().Equals(studentAnswers[loop].ToLower()))
                {
                    Console.WriteLine("Correct Answer");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect Answer");
                }
            }
            return score;
        }
    }
}
