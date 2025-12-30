using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzTraining.scenariobased
{
    internal class TemperatureAnalyzer
    {
        static void Main()                                                      // Entry point of the program
        {
            TemperatureAnalyzer temperature = new TemperatureAnalyzer();
            temperature.SystemInitialize();
        }
        void SystemInitialize()                                                 // Method to initialize the application
        {
            float[,] temperatureData = ReadTemperatureData();
            AnalyzeTemperatureData(temperatureData);
        }
        float[,] ReadTemperatureData()                                          // Method to read daily temperatures in a week
        {
            float[,] temperatureData = new float[7, 24];

            Console.WriteLine("Enter hourly temperature data for 7 days");

            for (int day = 0; day < 7; day++)
            {
                Console.WriteLine("Day " + (day + 1));

                for (int hour = 0; hour < 24; hour++)
                {
                    while (true)
                    {
                        Console.Write("Hour " + (hour + 1) + ": ");
                        if (float.TryParse(Console.ReadLine(), out temperatureData[day, hour]))
                        {
                            break;
                        }
                        Console.WriteLine("Invalid input. Enter a numeric value.");
                    }
                }
            }
            return temperatureData;
        }
        void AnalyzeTemperatureData(float[,] temperatureData)                   // Analyze daily temperature and calculate hottest and coldest day
        {
            float hottestAverage = float.MinValue;
            float coldestAverage = float.MaxValue;
            int hottestDay = 0;
            int coldestDay = 0;

            for (int day = 0; day < 7; day++)
            {
                float dailySum = CalculateDailySum(temperatureData, day);
                float dailyAverage = dailySum / 24;

                Console.WriteLine("Average temperature for Day " + (day + 1) + ": " + dailyAverage);

                if (dailyAverage > hottestAverage)
                {
                    hottestAverage = dailyAverage;
                    hottestDay = day + 1;
                }

                if (dailyAverage < coldestAverage)
                {
                    coldestAverage = dailyAverage;
                    coldestDay = day + 1;
                }
            }

            DisplayExtremeTemperatures(hottestDay, coldestDay);
        }
        float CalculateDailySum(float[,] temperatureData, int day)                  // Calculate daily average temperature of every hour
        {
            float sumOfTemperatures = 0;

            for (int hour = 0; hour < 24; hour++)
            {
                sumOfTemperatures += temperatureData[day, hour];
            }

            return sumOfTemperatures;
        }
        void DisplayExtremeTemperatures(int hottestDay, int coldestDay)             // Display the hottest and coldest day
        {
            Console.WriteLine();
            Console.WriteLine("Hottest Day:  " + hottestDay);
            Console.WriteLine("Coldest Day:  " + coldestDay);
        }
    }
}