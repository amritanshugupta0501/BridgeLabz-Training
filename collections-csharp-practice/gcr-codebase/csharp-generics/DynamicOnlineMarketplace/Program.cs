using System;

public class Program
{
    public static void Main()
    {
        Book b = new Book { Name = "C# Guide", Price = 50.0 };
        Clothing c = new Clothing { Name = "T-Shirt", Price = 20.0 };

        Marketplace.ApplyDiscount(b, 10);
        Marketplace.ApplyDiscount(c, 20);
    }
}