using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.SocialMediaManagementSystem
{
    internal class SocialMediaNetworkApplication
    {
        private UserNode Head;
        public void AddUser(int id, string name, int age)
        {
            UserNode newNode = new UserNode(id, name, age);
            newNode.Next = Head;
            Head = newNode;
        }
        public void AddFriendConnection(int userId1, int userId2)
        {
            UserNode u1 = SearchUserById(userId1);
            UserNode u2 = SearchUserById(userId2);
            if (u1 != null && u2 != null)
            {
                AddIdToArray(u1, userId2);
                AddIdToArray(u2, userId1);
            }
        }
        private void AddIdToArray(UserNode user, int friendId)
        {
            if (user.FriendCount >= UserNode.MaxFriends)
            {
                return;
            }
            bool exists = false;
            for (int i = 0; i < user.FriendCount; i++)
            {
                if (user.FriendIds[i] == friendId)
                {
                    exists = true;
                    break;
                }
            }
            if (!exists)
            {
                user.FriendIds[user.FriendCount] = friendId;
                user.FriendCount++;
            }
        }
        public void RemoveFriendConnection(int userId1, int userId2)
        {
            UserNode u1 = SearchUserById(userId1);
            UserNode u2 = SearchUserById(userId2);

            if (u1 != null && u2 != null)
            {
                RemoveIdFromArray(u1, userId2);
                RemoveIdFromArray(u2, userId1);
            }
        }
        private void RemoveIdFromArray(UserNode user, int friendId)
        {
            int index = -1;
            for (int i = 0; i < user.FriendCount; i++)
            {
                if (user.FriendIds[i] == friendId)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                for (int i = index; i < user.FriendCount - 1; i++)
                {
                    user.FriendIds[i] = user.FriendIds[i + 1];
                }
                user.FriendCount--;
            }
        }
        public void FindMutualFriends(int userId1, int userId2)
        {
            UserNode u1 = SearchUserById(userId1);
            UserNode u2 = SearchUserById(userId2);
            if (u1 != null && u2 != null)
            {
                for (int i = 0; i < u1.FriendCount; i++)
                {
                    for (int j = 0; j < u2.FriendCount; j++)
                    {
                        if (u1.FriendIds[i] == u2.FriendIds[j])
                        {
                            Console.WriteLine($"Mutual Friend ID: {u1.FriendIds[i]}");
                        }
                    }
                }
            }
        }
        private UserNode SearchUserById(int id)
        {
            UserNode current = Head;
            while (current != null)
            {
                if (current.UserId == id) return current;
                current = current.Next;
            }
            return null;
        }
        public void DisplayFriends(int userId)
        {
            UserNode user = SearchUserById(userId);
            if (user != null)
            {
                Console.Write($"Friends of {user.Name}: ");
                for (int i = 0; i < user.FriendCount; i++)
                {
                    Console.Write(user.FriendIds[i]);
                    if (i < user.FriendCount - 1) Console.Write(", ");
                }
                Console.WriteLine();
            }
        }
        public void CountFriends()
        {
            UserNode current = Head;
            while (current != null)
            {
                Console.WriteLine($"{current.Name} has {current.FriendCount} friends.");
                current = current.Next;
            }
        }
    }
}
