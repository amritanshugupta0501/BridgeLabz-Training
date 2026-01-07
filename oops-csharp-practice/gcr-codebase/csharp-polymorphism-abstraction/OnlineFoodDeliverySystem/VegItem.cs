using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.OnlineFoodDeliverySystem
{
    internal class VegItem : FoodItem, IDiscountable
    {
        public VegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity)
        {
        }

        public override double CalculateTotalPrice()
        {
            // Standard calculation: price * quantity
            return GetPrice() * GetQuantity();
        }

        public double ApplyDiscount(double totalCost)
        {
            // 10% discount on Veg items
            return totalCost * 0.10;
        }

        public string GetDiscountDetails()
        {
            return "Veg Discount (10%)";
        }
    }
}
