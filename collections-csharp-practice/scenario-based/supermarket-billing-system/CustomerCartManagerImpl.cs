using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.SupermarketBillingSystem
{
    // Class defined to manage the shopping cart of the customer
    internal class CustomerCartManagerImpl : ICustomerCartManager
    {
        // Linked list collection used to add products from the pantry to cart of the customer
        LinkedList<ProductDetails> Products = new LinkedList<ProductDetails>();
        // Dictionary defined to show the key-value relationship between customer(key) and products(value)
        Dictionary<string, LinkedList<ProductDetails>> CustomerCart = new Dictionary<string, LinkedList<ProductDetails>>();
        // Random class to generate random cost of the products
        static Random ProductCostGenerator = new Random();
        // Function to add a product to the cart of the customer
        public void AddAProductToTheCart(CustomerDetails customerDetails,string choice)
        {
            if (choice.Equals("1"))
            {
                ProductDetails productDetails = new ProductDetails();
                Console.WriteLine("Give Product Details : ");
                Console.Write("Product Name : ");
                productDetails.ProductName = Console.ReadLine();
                Console.Write("Product ID : ");
                productDetails.ProductId = Console.ReadLine();
                productDetails.ProductCost = ProductCostGenerator.Next(100, 201);
                Products.AddLast(productDetails);
            }
            else
            {
                CustomerCart.Add(customerDetails.CustomerName, Products);
            }
        }
        // Function to calculate total bill of the customer
        public void CalculateTotalBill(CustomerDetails customerDetails)
        {
            foreach (ProductDetails productDetails in CustomerCart[customerDetails.CustomerName])
            {
                customerDetails.TotalBill += productDetails.ProductCost;
            }
        }
        // Function to display all the products in the shopping cart
        public void DisplayAllProducts(CustomerDetails customerDetails)
        {
            foreach(ProductDetails productDetails in CustomerCart[customerDetails.CustomerName])
            {
                Console.WriteLine(productDetails.ToString());
            }
        }
    }
}
