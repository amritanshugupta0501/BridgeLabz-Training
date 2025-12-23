using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
// Display the youngest and the tallest friend among 3 friend
internal class YoungestTallestFriends
    {
        static void Main()
        {
            double[,] friends = new double[3, 2];
            for (int outerLoop = 0; outerLoop < 3; outerLoop++)							// Initiate a loop to take heights and ages from user
            {
                Console.WriteLine("Give the height(in cm) and age of friend " + (outerLoop + 1) + " :");
                for (int innerLoop = 0; innerLoop < 2; innerLoop++)
                {
                    friends[outerLoop, innerLoop] = double.Parse(Console.ReadLine());
                }
            }
	    // Display the youngest and tallest based on their heights and ages 
            String tallest = friends[0, 0] > friends[1, 0] ? (friends[0, 0] > friends[2, 0] ? "Amar" : "Anthony") : (friends[1,0] > friends[2,0] ? "Akbar" : "Anthony"); 
            String youngest = friends[0,1] < friends[1, 1] ? (friends[0, 1] < friends[2, 1] ? "Amar" : "Anthony") : (friends[1, 1] < friends[2, 1] ? "Akbar" : "Anthony");
            Console.WriteLine("Tallest among the three friends : "+tallest);
            Console.WriteLine("Youngest among the three friends : " + youngest);
        }
  }
