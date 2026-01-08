using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.SocialMediaManagementSystem
{
    internal class UserNode
    {
        public int UserId;
        public string Name;
        public int Age;
        public int[] FriendIds;
        public int FriendCount;
        public const int MaxFriends = 50;
        public UserNode Next;

        public UserNode(int id, string name, int age)
        {
            UserId = id;
            Name = name;
            Age = age;
            FriendIds = new int[MaxFriends];
            FriendCount = 0;
            Next = null;
        }
    }
}
