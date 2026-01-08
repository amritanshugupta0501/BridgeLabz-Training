using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.InventoryManagementSystem
{
    internal class InventoryNode
    {
        public int ItemId;
        public string ItemName;
        public int Quantity;
        public double Price;
        public InventoryNode Next;

        public InventoryNode(int id, string name, int quantity, double price)
        {
            ItemId = id;
            ItemName = name;
            Quantity = quantity;
            Price = price;
            Next = null;
        }
    }
}
