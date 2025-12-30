using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased
{
    internal class StudentScoreManager
    {
        static void Main()                                                                                                  // Entry point of the program
        {
            StudentScoreManager manager = new StudentScoreManager();
            manager.SystemInitializer();
        }
        public void SystemInitializer()                                                                                     // Method to initialize the application
        {
            int studentCount = GetStudentCount();
            double[] scores = ReadScores(studentCount);
            ProcessScores(scores);
        }
        private int GetStudentCount()                                                                                       // Method to input number of students from the user
        {
            Console.Write("Enter number of students: ");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive integer.");
            }
            return count;
        }
        private double[] ReadScores(int count)                                                                              // Input scores of the students
        {
            double[] scores = new double[count];

            for (int i = 0; i < count; i++)
            {
                while (true)
                {
                    Console.Write("Enter score for student " + (i + 1) + ": ");
                    if (double.TryParse(Console.ReadLine(), out scores[i]) && scores[i] >= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid score. Enter a non-negative number.");
                }
            }

            return scores;
        }
        private void ProcessScores(double[] scores)                                                                          // Analyze students scores
        {
            double total = CalculateTotal(scores);
            double average = total / scores.Length;

            double highest = FindHighest(scores);
            double lowest = FindLowest(scores);

            DisplaySummary(average, highest, lowest);
            DisplayAboveAverage(scores, average);
        }
        private double CalculateTotal(double[] scores)                                                                       // Calculate total of all the scores 
        {
            double sum = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }

            return sum;
        }
        private double FindHighest(double[] scores)                                                                           // Display the highest score among the students
        {
            double max = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                }
            }

            return max;
        }
        private double FindLowest(double[] scores)                                                                          // Display the lowest score among the students
        {
            double min = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < min)
                {
                    min = scores[i];
                }
            }

            return min;
        }
        private void DisplaySummary(double average, double highest, double lowest)
        {
            Console.WriteLine();
            Console.WriteLine("Average Score: " + average);
            Console.WriteLine("Highest Score: " + highest);
            Console.WriteLine("Lowest Score: " + lowest);
        }
        private void DisplayAboveAverage(double[] scores, double average)                                                     // Display the scores which are above average
        {
            Console.WriteLine();
            Console.WriteLine("Scores above average:");

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > average)
                {
                    Console.WriteLine(scores[i]);
                }
            }
        }
    }
}