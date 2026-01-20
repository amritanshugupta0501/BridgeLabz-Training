using System;

public class Program
{
    public static void Main()
    {
        Storage<Electronics> eStorage = new Storage<Electronics>();
        eStorage.AddItem(new Electronics("Laptop"));
        eStorage.AddItem(new Electronics("Smartphone"));
        eStorage.DisplayItems();

        Storage<Groceries> gStorage = new Storage<Groceries>();
        gStorage.AddItem(new Groceries("Rice"));
        gStorage.DisplayItems();
    }
}