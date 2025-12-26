using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level3
{
    internal class StudentGrades
    {
        static int[,] CreateMarks(int count)					// create random marks for students
        {
            int[,] scores = new int[count, 3];
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                scores[i, 0] = random.Next(10, 100);
                scores[i, 1] = random.Next(10, 100);
                scores[i, 2] = random.Next(10, 100);
            }

            return scores;
        }
        static double[,] ComputeStatistics(int[,] scores)			//compute Total, Average and Percentage
        {
            int count = scores.GetLength(0);
            double[,] stats = new double[count, 3];

            for (int i = 0; i < count; i++)
            {
                int sum = scores[i, 0] + scores[i, 1] + scores[i, 2];
                double avg = sum / 3.0;
                double percent = (sum / 300.0) * 100;

                stats[i, 0] = sum;
                stats[i, 1] = Math.Round(avg, 2);
                stats[i, 2] = Math.Round(percent, 2);
            }

            return stats;
        }
        static void PrintScorecard(int[,] scores, double[,] stats)		//print Scorecard
        {
            Console.WriteLine("ID\tPhy\tChem\tMath\tTotal\tAvg\t%");

            for (int i = 0; i < scores.GetLength(0); i++)
            {
                Console.WriteLine(
                    (i + 1) + "\t" +
                    scores[i, 0] + "\t" +
                    scores[i, 1] + "\t" +
                    scores[i, 2] + "\t" +
                    stats[i, 0] + "\t" +
                    stats[i, 1] + "\t" +
                    stats[i, 2]
                );
            }
        }
	static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");			//Read number of students
            int totalStudents = int.Parse(Console.ReadLine());

            int[,] marks = CreateMarks(totalStudents);
            double[,] resultData = ComputeStatistics(marks);
            PrintScorecard(marks, resultData);
        }
    }
}
