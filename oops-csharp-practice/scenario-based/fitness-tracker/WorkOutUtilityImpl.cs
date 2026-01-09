using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.fitnesstracker
{
    // Utility class to implement all the necessary functionalities
    internal class WorkOutUtilityImpl : ITrackable
    {
        static protected UserProfile[] Profile = new UserProfile[100];
        static int CountUsers = 0;
        // Function to add a user to the system
        public void AddUserProfile()
        {
            Profile[CountUsers] = new UserProfile();
            Console.Write("Give User Name : ");
            Profile[CountUsers].UserName1 = Console.ReadLine();
            Console.Write("Give User Gender : ");
            Profile[CountUsers].UserGender1 = Console.ReadLine();
            Console.Write("Give User Age : ");
            Profile[CountUsers].UserAge1 = int.Parse(Console.ReadLine());
            Console.Write("Give User Height : ");
            Profile[CountUsers].UserHeight1 = double.Parse(Console.ReadLine());
            Console.Write("Give User Weight : ");
            Profile[CountUsers].UserWeight1 = double.Parse(Console.ReadLine());
            Profile[CountUsers].UserId1 = ++CountUsers;
        }
        // Function to view all the registered users 
        public void ViewUsersList()
        {
            for (int user = 0; user < CountUsers; user++)
            {
                Console.WriteLine(Profile[user].UserId1+". "+Profile[user].UserName1);
            }
        }
        // Function to view the detail of a user
        public void DisplayUserDetails()
        {
            ViewUsersList();
            Console.Write("Select the user id to display their information : ");
            int user = int.Parse(Console.ReadLine());
            Console.WriteLine(Profile[user-1].ToString());
        }
        // Function to commence the training session of the applicant
        public void InitializeTheSession()
        {
            ViewUsersList();
            Console.Write("Select the user id to commence the workout session : ");
            int user = int.Parse(Console.ReadLine());
            ITrackable fitnessTrack;
            while (true)
            {
                Console.Write("Select the type of workout you want to do :-\n1. Cardio Workout\n2. Strength Workout\n0. Exit the Session\n");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch(choice)
                {
                    case 0:
                        return;
                    case 1:
                        fitnessTrack = new CardioWorkOut(user);
                        Console.WriteLine();
                        break;
                    case 2:
                        fitnessTrack = new StrengthWorkOut(user);
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
