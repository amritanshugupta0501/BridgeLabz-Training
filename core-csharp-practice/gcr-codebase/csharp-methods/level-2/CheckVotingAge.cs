using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class CheckVotingAge
    {
        bool VotingAge(int age)
        {
            return age >= 18;
        }
        static void Main()
        {
            int[] students = new int[10];
            for (int loop = 0; loop < 10; loop++)
            {
                Console.WriteLine("Give the age of student " + (loop+1) + " : ");
                students[loop] = int.Parse(Console.ReadLine());
            }
            CheckVotingAge age = new CheckVotingAge();
            for (int loop = 0; loop < 10; loop++)
            {
                if (age.VotingAge(students[loop]))
                {
                    Console.WriteLine("Student " + (loop+1) + " is eligible to vote.");
                }
                else 
                {
                    Console.WriteLine("Student " + (loop+1) + " is not eligible to vote.");
                }
            }
        }
    }
}
