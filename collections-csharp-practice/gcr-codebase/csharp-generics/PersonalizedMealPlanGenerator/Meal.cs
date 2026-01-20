public class Meal<T> where T : IMealPlan, new()
{
    public T CreateMeal()
    {
        return new T();
    }
}