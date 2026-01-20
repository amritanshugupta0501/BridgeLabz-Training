using System;
using System.Collections.Generic;

public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine($"Item: {item.Name}, Type: {typeof(T).Name}");
        }
    }
}