using System;

public class MealManager
{
    public static void GenerateMealPlan<T>(T meal) where T : IMealPlan
    {
        Console.WriteLine($"Generated Plan: {meal.Description}");
    }
}