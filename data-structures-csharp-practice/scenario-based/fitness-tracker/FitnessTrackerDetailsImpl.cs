using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.fitnesstracker
{
    // Utility class to perform the operations for the application
    internal class FitnessTrackerDetailsImpl : IFitnessTrackerDetails
    {
        // Random class instance to generate random steps for the user
        static Random NumberOfSteps = new Random();
        UserNode Head;
        static int Time;
        // Function to count users in the list or a group
        public int CountUsers()
        {
            int count;
            UserNode current = Head;
            count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
        // Function to add a user to the group
        public void AddUserInAGroup()
        {
            Console.WriteLine("Get User Details : ");
            Console.Write("User Name : ");
            string userName = Console.ReadLine();
            Console.Write("User Age : ");
            string userAge = Console.ReadLine();
            Console.Write("User Weight : ");
            string userWeight = Console.ReadLine();
            Console.Write("User Height : ");
            string userHeight = Console.ReadLine();
            int numberOfSteps = 0;
            var userDetails = new UserDetail(userName, userAge, userWeight, userHeight, numberOfSteps);
            var newUser = new UserNode(userDetails);
            if (Head == null)
            {
                Head = newUser;
                return;
            }
            UserNode current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newUser;
        }
        // Function to Generate ranking among the group members for every hour
        public void GenerateHourlyRankingsAmongTheGroup()
        {
            Time++;
            GenerateStepsForEachUser();
            if (Time != 24)
            {
                Console.WriteLine($"For the {Time} hour : the rankings are as follows : ");
            }
            else
            {
                Console.WriteLine("By the end of the Day, the rankings are as follows : ");
            }
            UserNode[] usersInTheGroup = new UserNode[CountUsers()];
            UserNode current = Head;
            int index = 0;
            while (current != null)
            {
                usersInTheGroup[index] = current;
                index++;
                current = current.Next;
            }
            // Sort the user rankings based on the number of steps within the group using bubble sort
            bool swapped;
            for (int outerLoop = 0; outerLoop < index; outerLoop++)
            {
                swapped = false;
                for (int innerLoop = 0; innerLoop < index - outerLoop - 1; innerLoop++)
                {
                    int user1NumberOfSteps = usersInTheGroup[innerLoop].Detail.UserSteps1;
                    int user2NumberOfSteps = usersInTheGroup[innerLoop + 1].Detail.UserSteps1;
                    if (user1NumberOfSteps > user2NumberOfSteps)
                    {
                        UserNode swapper = usersInTheGroup[innerLoop];
                        usersInTheGroup[innerLoop] = usersInTheGroup[innerLoop+1];
                        usersInTheGroup[innerLoop+1] = swapper;
                        swapped = true;
                    }
                }
                if(!swapped)
                {
                    break;
                }
            }
            // Display the rankings
            index = 0;
            for (int loop = CountUsers() - 1; loop >= 0; loop--)
            {
                Console.WriteLine((++index) + ". " + usersInTheGroup[loop].Detail.ToString());
                Console.WriteLine();
            }
        }
        // Function to Generate steps for each user in the group for every hour 
        public void GenerateStepsForEachUser()
        {
            UserNode current = Head;
            while (current != null)
            {
                current.Detail.UserSteps1 += NumberOfSteps.Next(500, 1501);
                current = current.Next;
            }
        }
    }
}
