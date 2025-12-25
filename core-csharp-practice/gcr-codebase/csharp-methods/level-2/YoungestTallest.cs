using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class YoungestTallest
    {
        string TallestFriend(double heightOfAmar, double heightOfAkbar, double heightOfAnthony)
        {
            return (heightOfAmar > heightOfAkbar) ? ((heightOfAmar > heightOfAnthony) ? "Amar" : "Anthony") : (heightOfAkbar > heightOfAnthony) ? "Akbar" : "Anthony";
        }
        string YoungestFriend(double ageOfAmar, double ageOfAkbar, double ageOfAnthony)
        {
            return (ageOfAmar < ageOfAkbar) ? ((ageOfAmar < ageOfAnthony) ? "Amar" : "Anthony") : (ageOfAkbar < ageOfAnthony) ? "Akbar" : "Anthony";
        }
        static void Main()
        {
            double[,] friendsDetails = new double[3, 2];  
            for(int loop = 0; loop < 3; loop++)
            {
                Console.WriteLine("Give the height and age of friend "+loop+" :");
                friendsDetails[loop,0] = double.Parse(Console.ReadLine());
                friendsDetails[loop,1] = double.Parse(Console.ReadLine());
            }
            YoungestTallest friend = new YoungestTallest();
            string tallest = friend.TallestFriend(friendsDetails[0,0], friendsDetails[1,0], friendsDetails[2,0]);
            string youngest = friend.YoungestFriend(friendsDetails[0,1], friendsDetails[1,1], friendsDetails[2,1]);
            Console.WriteLine("Tallest among Amar, Akbar, Anthony : " + tallest);
            Console.WriteLine("Youngest among Amar, Akbar, Anthony : " + youngest);
        }
    }
}
