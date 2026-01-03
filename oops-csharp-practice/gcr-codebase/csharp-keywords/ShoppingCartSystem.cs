using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpkeywords
{
    internal class ShoppingCartSystem
    {
        public static double discountRate = 5.0;
        public readonly int productId;
        public string productName;
        public double productPrice;
        public int quantity;
        public ShoppingCartSystem(int productId, string productName,  double productPrice,  int quantity)   // Constructor defined to get attributes of a product
        {
            this.productId = productId;
            this.productName = productName;
            this.productPrice = productPrice;
            this.quantity = quantity;
        }
        public static void UpdateDiscount(double newDiscount)                                         // Function to update discount on a product
        {
            discountRate = newDiscount;
        }
        public void DisplayProductDetails()                                                           // Function to display attributed of the product
        {
            double finalPrice = productPrice * (1 - (discountRate / 100));
            Console.WriteLine("Product Details : ");
            Console.WriteLine("Product Id : "+productId);
            Console.WriteLine("Product Name : "+productName);
            Console.WriteLine("Product Quantity : "+quantity);
            Console.WriteLine("Base Price : "+productPrice);
            Console.WriteLine("Discount Rate : "+discountRate);
            Console.WriteLine("Price After Discount : "+finalPrice);
        }
    }
    class Program
    {
        static void Main()                                                                              // Entry point of the application
        {
            Console.WriteLine("Give Product Details : ");
            Console.Write("Product id : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Product name : ");
            string name = Console.ReadLine();
            Console.Write("Product price : ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Product quantity : ");
            int quantity = int.Parse(Console.ReadLine());
            ShoppingCartSystem cart = new ShoppingCartSystem(id, name, price, quantity);                // Constructor called to create an instance 
            ShoppingCartSystem.UpdateDiscount(15.0);
            if (cart is ShoppingCartSystem)                                                             // Checking the type of object using 'is' operator
            {
                cart.DisplayProductDetails();
            }
            else
            {
                Console.WriteLine("Invalid Object.");
            }
        }
    }
}
