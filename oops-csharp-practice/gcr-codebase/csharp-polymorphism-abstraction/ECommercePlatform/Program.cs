using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.ECommercePlatform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] cart = new Product[]
            {
            new Electronics("E101", "Smartphone", 800.00),
            new Clothing("C202", "Jeans", 50.00),
            new Groceries("G303", "Rice Bag", 20.00)
            };

            ProcessOrder(cart);
        }

        public static void ProcessOrder(Product[] products)
        {
            Console.WriteLine("Processing Order...\n");

            foreach (Product product in products)
            {
                double price = product.GetPrice();
                double discount = product.CalculateDiscount();
                double tax = 0;

                if (product is ITaxable)
                {
                    tax = ((ITaxable)product).CalculateTax();
                }

                double finalPrice = price + tax - discount;

                Console.WriteLine("Product: " + product.GetName());
                Console.WriteLine("Base Price: $" + price);
                Console.WriteLine("Discount: -$" + discount);

                if (product is ITaxable)
                {
                    Console.WriteLine(((ITaxable)product).GetTaxDetails() + ": +$" + tax);
                }
                else
                {
                    Console.WriteLine("Tax: $0.00 (Not Applicable)");
                }

                Console.WriteLine("Final Price: $" + finalPrice);
            }
        }
    }
}
