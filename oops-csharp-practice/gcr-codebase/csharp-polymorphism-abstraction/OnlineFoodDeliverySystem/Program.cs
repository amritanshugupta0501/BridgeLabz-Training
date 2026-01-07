using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.OnlineFoodDeliverySystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FoodItem[] order = new FoodItem[]
            {
            new VegItem("Paneer Tikka", 120.00, 2),
            new NonVegItem("Chicken Biryani", 250.00, 1),
            new VegItem("Salad", 50.00, 1)
            };
            ProcessOrder(order);
        }

        public static void ProcessOrder(FoodItem[] items)
        {
            Console.WriteLine("Processing Food Order...\n");
            double grandTotal = 0;
            foreach (FoodItem item in items)
            {
                double totalPrice = item.CalculateTotalPrice();
                double discount = 0;
                Console.WriteLine(item.GetItemDetails());
                Console.WriteLine("Subtotal: $" + totalPrice);

                if (item is IDiscountable)
                {
                    discount = ((IDiscountable)item).ApplyDiscount(totalPrice);
                    Console.WriteLine(((IDiscountable)item).GetDiscountDetails() + ": -$" + discount);
                }
                double finalItemPrice = totalPrice - discount;
                grandTotal += finalItemPrice;
                Console.WriteLine("Final Item Price: $" + finalItemPrice);
            }
            Console.WriteLine("Grand Total Amount to Pay: $" + grandTotal);
        }
    }
}
