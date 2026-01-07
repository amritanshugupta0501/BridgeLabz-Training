using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.OnlineFoodDeliverySystem
{
    internal class NonVegItem : FoodItem, IDiscountable
    {
        private double PackagingCharge;

        public NonVegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity)
        {
            PackagingCharge = 25.00; // Flat packaging charge
        }

        public override double CalculateTotalPrice()
        {
            // Price * quantity + packaging charge
            return (GetPrice() * GetQuantity()) + PackagingCharge;
        }

        public double ApplyDiscount(double totalCost)
        {
            // 5% discount on Non-Veg items
            return totalCost * 0.05;
        }

        public string GetDiscountDetails()
        {
            return "Non-Veg Discount (5%)";
        }
    }
}
