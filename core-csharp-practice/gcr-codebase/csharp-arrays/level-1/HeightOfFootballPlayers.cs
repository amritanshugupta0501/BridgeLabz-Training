using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

// Compute mean height of football players and display result
    internal class HeightOfFootballPlayers
    {
        static void Main()
        {
            double[,] footballHeight = new double[2, 11];
            double sum = 0;
            Console.WriteLine("Enter the height of football players : ");			// Input height of football players from user
            for(int loop = 0;  loop < 11; loop++)
            {
                footballHeight[0, loop] = loop + 1;
                footballHeight[1,loop] = double.Parse(Console.ReadLine());
                sum += footballHeight[1, loop];							// Compute sum of height of all the players
            }
            double average = sum / 11;								// Average height = (sum of height of players)/total players
            Console.WriteLine("Mean height of the football team : "+average);
        }
    }

