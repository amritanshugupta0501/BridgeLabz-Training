using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.InventoryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        InventoryManagementApplication inv = new InventoryManagementApplication();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Inventory System ---");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. Update Quantity");
                Console.WriteLine("4. Search");
                Console.WriteLine("5. Total Value");
                Console.WriteLine("6. Sort by Name Ascending");
                Console.WriteLine("7. Sort by Name Descending");
                Console.WriteLine("0. Back");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();
                if (choice == "0")
                { 
                    break; 
                }
                switch (choice)
                {
                    case "1":
                        Console.Write("ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Qty: ");
                        int qty = int.Parse(Console.ReadLine());
                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine());
                        inv.AddAtEnd(id, name, qty, price);
                        break;
                    case "2":
                        Console.Write("ID to Remove: ");
                        inv.RemoveByItemId(int.Parse(Console.ReadLine()));
                        break;
                    case "3":
                        Console.Write("ID: ");
                        int uid = int.Parse(Console.ReadLine());
                        Console.Write("New Qty: ");
                        int uqty = int.Parse(Console.ReadLine());
                        inv.UpdateQuantity(uid, uqty);
                        break;
                    case "4":
                        Console.Write("ID or Name: ");
                        var item = inv.SearchByIdOrName(Console.ReadLine());
                        if (item != null)
                        {
                            Console.WriteLine($"Found: {item.ItemName}, Qty: {item.Quantity}");
                        }
                        else
                        {
                            Console.WriteLine("Not Found"); 
                        }
                        break;
                    case "5":
                        inv.CalculateTotalValue();
                        break;
                    case "6":
                        inv.SortByItemName(true);
                        Console.WriteLine("Sorted Ascending.");
                        break;
                    case "7":
                        inv.SortByItemName(false);
                        Console.WriteLine("Sorted Descending.");
                        break;
                }
            }
        }
    }
}
