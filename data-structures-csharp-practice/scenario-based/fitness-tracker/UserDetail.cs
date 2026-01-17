using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.fitnesstracker
{
    // Class to define the characteristics for a user
    internal class UserDetail
    {
        string UserName;
        string UserAge;
        string UserWeight;
        string UserHeight;
        int UserSteps;
        public int UserSteps1 { get => UserSteps; set => UserSteps = value; }
        public UserDetail(string userName, string userAge,string userWeight, string userHeight, int userSteps)
        {
            UserName = userName;
            UserAge = userAge;
            UserWeight = userWeight;
            UserHeight = userHeight;
            UserSteps = userSteps;
        }

        public override string? ToString()
        {
            return $"User Name : {UserName}\nUser Age : {UserAge}\nUser Height : {UserHeight}\nUser Weight : {UserWeight}\nNumber of steps walked : {UserSteps1}";
        }
    }
}
