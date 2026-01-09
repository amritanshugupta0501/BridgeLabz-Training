using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.fitnesstracker
{
    // Interface to display the behaviour of the class
    internal interface ITrackable
    {
        void AddUserProfile();
        void ViewUsersList();
        void DisplayUserDetails();
        void InitializeTheSession();
    }
}
