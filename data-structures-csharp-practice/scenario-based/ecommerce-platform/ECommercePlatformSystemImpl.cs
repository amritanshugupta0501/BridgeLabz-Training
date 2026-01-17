using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.ecommerceplatform
{
    // ECommerce Platform application to show top discounted items in the pantry of an ECommerce website using Quick Sort
    // Utility class of the platform application to provide basic functionalities
    internal class ECommercePlatformSystemImpl : IECommercePlatformSystem
    {
        ProductNode Head;
        // Random class instance to generate discounts on the products
        static Random DiscountGenerator = new Random();
        // Function to count products in the pantry
        public int CountProducts()
        {
            int count = 0;
            ProductNode current = Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
        // Function to add a product in the pantry list
        public void AddProductInThePantry()
        {
            Console.WriteLine("Give Product Details : ");
            Console.Write("Product Name : ");
            string productName = Console.ReadLine();
            Console.Write("Product Type : ");
            string productType = Console.ReadLine();
            Console.Write("Product Cost : ");
            double productCost = double.Parse(Console.ReadLine());
            double productDiscount = GenerateDiscountForAProduct();
            var product = new ProductDetails(productName, productType, productCost, productDiscount);
            var newProduct = new ProductNode(product);
            if (Head == null)
            {
                Head = newProduct;
                return;
            }
            ProductNode current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newProduct;
        }
        // Function to generate discount for every product in the pantry
        public int GenerateDiscountForAProduct()
        {
            return DiscountGenerator.Next(4, 46);
        }
        // Function to sort all the products in the pantry list based on their discounts using quick sort algorithm
        public void DisplayTheHighestDiscountedProducts()
        {
            ProductNode[] products = new ProductNode[CountProducts()];
            ProductNode current = Head;
            int index = 0;
            while (current != null)
            {
                products[index++] = current;
                current = current.Next;
            }
            products = SortedProductsList(products, 0, products.Length - 1);
            index = 0;
            for (int loop = products.Length - 1; loop >= 0; loop--)
            {
                Console.WriteLine((++index) + ". " + products[loop].Product.ToString());
                Console.WriteLine();
            }
        }
        // Function to perform Quick sort on the products list
        public ProductNode[] SortedProductsList(ProductNode[] products, int low, int high)
        {
            if (low < high)
            {
                int pivot = PartitionInProducts(products, low, high);
                products = SortedProductsList(products, low, pivot - 1);
                products = SortedProductsList(products, pivot + 1, high);
            }
            return products;
        }
        // Function to provide the partition or the pivot element in the products list
        public int PartitionInProducts(ProductNode[] products, int low, int high)
        {
            double pivot = products[high].Product.ProductDiscount1;
            int loop = low - 1;
            for (int outerLoop = low; outerLoop < high; outerLoop++)
            {
                if (products[outerLoop].Product.ProductDiscount1 < pivot)
                {
                    loop++;
                    ProductNode swapped = products[loop];
                    products[loop] = products[outerLoop];
                    products[outerLoop] = swapped;
                }
            }
            ProductNode swapper = products[loop + 1];
            products[loop + 1] = products[high];
            products[high] = swapper;
            return loop + 1;
        }
    }
}
