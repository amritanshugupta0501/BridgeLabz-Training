using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.fitnesstracker
{
    // StrengthWorkOut class(child class) declared to define behaviour of strength type workout
    internal class StrengthWorkOut : WorkOutUtilityImpl
    {
        static Random WorkOut = new Random();
        public StrengthWorkOut(int user)
        {
            CalculateCalories(user);
        }
        // Function to calculate calories of strength work out
        public  void CalculateCalories(int user)
        {
            double sessionTime;
            double caloriesBurnt;
            sessionTime = WorkOut.Next(40, 81);
            Profile[user-1].WorkoutTime1 += sessionTime;
            caloriesBurnt = sessionTime * WorkOut.Next(2, 11);
            Profile[user-1].CaloriesBurnt1 += caloriesBurnt;
            Console.WriteLine("Struength Work Out Session Time : " + sessionTime);
            Console.WriteLine("Calories Burnt During the Session Time : " + caloriesBurnt);
        }
    }
}
