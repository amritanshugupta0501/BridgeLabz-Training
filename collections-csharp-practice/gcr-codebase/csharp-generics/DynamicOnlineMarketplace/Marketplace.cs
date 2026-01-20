using System;

public class Marketplace
{
    public static void ApplyDiscount<T>(T product, double percentage) where T : Product
    {
        double discountAmount = product.Price * (percentage / 100);
        product.Price -= discountAmount;
        Console.WriteLine($"Discount Applied to {product.Name}. New Price: {product.Price}");
    }
}