using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.fitnesstracker
{
    // Encapsulated class to define user attributes and behaviours
    internal class UserProfile
    {
        private int UserId;
        private string UserName;
        private string UserGender;
        private int UserAge;
        private double UserWeight;
        private double UserHeight;
        private double WorkoutTime;
        private double CaloriesBurnt;
        public int UserId1 { get => UserId; set => UserId = value; }
        public string UserName1 { get => UserName; set => UserName = value; }
        public string UserGender1 { get => UserGender; set => UserGender = value; }
        public int UserAge1 { get => UserAge; set => UserAge = value; }
        public double UserWeight1 { get => UserWeight; set => UserWeight = value; }
        public double UserHeight1 { get => UserHeight; set => UserHeight = value; }
        public double WorkoutTime1 { get => WorkoutTime; set => WorkoutTime = value; }
        public double CaloriesBurnt1 { get => CaloriesBurnt; set => CaloriesBurnt = value; }

        public override string? ToString()
        {
            return $"Name : {UserName1}\nId Number : {UserId1}\nGender : {UserGender1}\nAge : {UserAge1}\nWeight : {UserWeight1}\nHeight : {UserHeight1}\nTotal Workout Time : {WorkoutTime1} mins\nTotal Calories Burnt : {CaloriesBurnt1} cal";
        }
    }
}
