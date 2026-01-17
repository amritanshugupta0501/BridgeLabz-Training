using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.fitnesstracker
{
    // Node class with user details for a group list
    internal class UserNode
    {
        public UserDetail Detail;
        public UserNode Next;
        public UserNode(UserDetail user) 
        {
            Detail = user;
            Next = null;
        }
    }
}
