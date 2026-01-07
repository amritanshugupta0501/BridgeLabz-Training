using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.OnlineFoodDeliverySystem
{
    internal abstract class FoodItem
    {
        private string ItemName;
        private double Price;
        private int Quantity;

        public FoodItem(string itemName, double price, int quantity)
        {
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
        }

        public string GetItemName()
        {
            return ItemName;
        }

        public void SetItemName(string itemName)
        {
            ItemName = itemName;
        }

        public double GetPrice()
        {
            return Price;
        }

        public void SetPrice(double price)
        {
            Price = price;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        public string GetItemDetails()
        {
            return "Item: " + ItemName + " | Price: $" + Price + " | Qty: " + Quantity;
        }

        public abstract double CalculateTotalPrice();
    }
}
