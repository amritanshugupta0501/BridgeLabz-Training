using System;

public class Program
{
    public static void Main()
    {
        Meal<VegetarianMeal> vegKitchen = new Meal<VegetarianMeal>();
        VegetarianMeal veg = vegKitchen.CreateMeal();
        MealManager.GenerateMealPlan(veg);

        Meal<KetoMeal> ketoKitchen = new Meal<KetoMeal>();
        KetoMeal keto = ketoKitchen.CreateMeal();
        MealManager.GenerateMealPlan(keto);
    }
}