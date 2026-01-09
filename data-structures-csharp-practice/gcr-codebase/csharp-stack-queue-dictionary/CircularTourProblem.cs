using System;

namespace StackQueueCS
{
    public class PetrolPump
    {
        public int Petrol { get; }
        public int Distance { get; }

        public PetrolPump(int petrol, int distance)
        {
            Petrol = petrol;
            Distance = distance;
        }
    }

    public static class CircularTour
    {
        public static int FindStartingPoint(PetrolPump[] pumps)
        {
            int n = pumps.Length;
            int start = 0;
            int totalSurplus = 0;
            int currentSurplus = 0;

            for (int i = 0; i < n; i++)
            {
                int gain = pumps[i].Petrol - pumps[i].Distance;
                totalSurplus += gain;
                currentSurplus += gain;

                if (currentSurplus < 0)
                {
                    start = i + 1;
                    currentSurplus = 0;
                }
            }

            return (totalSurplus >= 0) ? start : -1;
        }

        public static void Run()
        {
            var pumps = new PetrolPump[] {
                new PetrolPump(4, 6),
                new PetrolPump(6, 5),
                new PetrolPump(7, 3),
                new PetrolPump(4, 5)
            };

            int startIndex = FindStartingPoint(pumps);
            if (startIndex != -1)
                Console.WriteLine("Start at petrol pump index: " + startIndex);
            else
                Console.WriteLine("No solution exists.");
        }
    }
}
