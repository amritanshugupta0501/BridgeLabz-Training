using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level3
{
    internal class FootballTeamHeights
    {
        int SumOfHeights(int[] heights)
        {
            int sumOfHeights = 0;
            for (int loop = 0; loop < heights.Length; loop++)
            {
                sumOfHeights += heights[loop];
            }
            return sumOfHeights;
        }
        double MeanOfHeights(int[] heights)
        {
            int sumOfHeights = new FootballTeamHeights().SumOfHeights(heights);
            return sumOfHeights/heights.Length;
        }
        int ShortestHeight(int[] heights)
        {
            int shortest = heights[0];
            for (int loop = 0; loop < heights.Length; loop++) 
            {
                if(shortest > heights[loop])
                {
                    shortest = heights[loop];
                }
            }
            return shortest;
        }
        int TallestHeight(int[] heights) 
        {
            int tallest = heights[0];
            for(int loop = 0;loop < heights.Length; loop++)
            {
                if(tallest < heights[loop])
                {
                    tallest = heights[loop];
                }
            }
            return tallest;
        }
        static void Main()
        {
            int[] teamHeights = new int[11];
            Random rnd = new Random();
            for (int loop = 0; loop < 11; loop++)
            {
                teamHeights[loop] = rnd.Next(150, 251);
            }
            FootballTeamHeights heights = new FootballTeamHeights();
            int sum = heights.SumOfHeights(teamHeights);
            double mean = heights.MeanOfHeights(teamHeights);
            int shortest = heights.ShortestHeight(teamHeights);
            int tallest = heights.TallestHeight(teamHeights);
            Console.WriteLine("Sum of heights of the football team : "+sum);
            Console.WriteLine("Mean of heights of the football team  : " + mean);
            Console.WriteLine("Shortest height among the football team : " + shortest);
            Console.WriteLine("Tallest height among the football team : "+tallest);
        }
    }
}
