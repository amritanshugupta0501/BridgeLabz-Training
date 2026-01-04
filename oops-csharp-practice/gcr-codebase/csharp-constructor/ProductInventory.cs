using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructor
{
    internal class ProductInventory
    {
        string productName;
        double productPrice;
        static int totalProducts = 0;
        public ProductInventory()
        {
            productName = "Pen";
            productPrice = 10;
            totalProducts++;
        }
        public ProductInventory(string productName, double productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            totalProducts++;
        }
        public void DisplayTotalProducts()
        {
            Console.WriteLine("Total products in the inventory : " + totalProducts);
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Name : " + productName);
            Console.WriteLine("Product Price : " + productPrice);
        }
    }
    class Program
    {
        static void Main()
        {
            ProductInventory inventory = new ProductInventory();
            inventory.DisplayTotalProducts();
            inventory.DisplayProductDetails();
            Console.WriteLine("Give the product Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Give the price of the product : ");
            double price = double.Parse(Console.ReadLine());
            ProductInventory inventory1 = new ProductInventory(name, price);
            inventory1.DisplayTotalProducts();
            inventory1.DisplayProductDetails();
        }
    }
}
