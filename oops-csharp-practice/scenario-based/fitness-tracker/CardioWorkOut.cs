using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.fitnesstracker
{
    // CardioWorkOut class(child class) declared to define behaviour of cardio type workout
    internal class CardioWorkOut : WorkOutUtilityImpl
    {
        static Random WorkOut = new Random();
        public CardioWorkOut(int user)
        {
            CalculateCalories(user);
        }
        // Function to calculate calories of cardio workout
        public void CalculateCalories(int user)
        {
            double sessionTime;
            double caloriesBurnt;
            sessionTime = WorkOut.Next(30, 41);
            Profile[user-1].WorkoutTime1 += sessionTime;
            caloriesBurnt = sessionTime * WorkOut.Next(10, 16);
            Console.WriteLine("Cardio Work Out Session Time : " + sessionTime);
            Console.WriteLine("Calories Burnt During the Session Time : " + caloriesBurnt);
            Profile[user-1].CaloriesBurnt1 += caloriesBurnt;
        }
    }
}
