using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.InventoryManagementSystem
{
    internal class InventoryManagementApplication
    {
        private InventoryNode Head;

        public void AddAtEnd(int id, string name, int quantity, double price)
        {
            InventoryNode newNode = new InventoryNode(id, name, quantity, price);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            InventoryNode current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void RemoveByItemId(int id)
        {
            if (Head == null) return;
            if (Head.ItemId == id)
            {
                Head = Head.Next;
                return;
            }
            InventoryNode current = Head;
            while (current.Next != null && current.Next.ItemId != id)
            {
                current = current.Next;
            }
            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        public void UpdateQuantity(int id, int newQuantity)
        {
            InventoryNode current = Head;
            while (current != null)
            {
                if (current.ItemId == id)
                {
                    current.Quantity = newQuantity;
                    return;
                }
                current = current.Next;
            }
        }

        public InventoryNode SearchByIdOrName(string query)
        {
            InventoryNode current = Head;
            bool isNumeric = int.TryParse(query, out int id);
            while (current != null)
            {
                if (current.ItemName == query || (isNumeric && current.ItemId == id))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void CalculateTotalValue()
        {
            double total = 0;
            InventoryNode current = Head;
            while (current != null)
            {
                total += (current.Price * current.Quantity);
                current = current.Next;
            }
            Console.WriteLine($"Total Inventory Value: {total}");
        }

        public void SortByItemName(bool ascending)
        {
            if (Head == null || Head.Next == null) return;
            bool swapped;
            do
            {
                swapped = false;
                InventoryNode current = Head;
                while (current.Next != null)
                {
                    bool condition = ascending
                        ? string.Compare(current.ItemName, current.Next.ItemName) > 0
                        : string.Compare(current.ItemName, current.Next.ItemName) < 0;

                    if (condition)
                    {
                        SwapData(current, current.Next);
                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);
        }

        private void SwapData(InventoryNode itemInInventory1, InventoryNode itemInInventory2)
        {
            int tempId = itemInInventory1.ItemId;
            string tempName = itemInInventory1.ItemName;
            int tempQty = itemInInventory1.Quantity;
            double tempPrice = itemInInventory1.Price;

            itemInInventory1.ItemId = itemInInventory2.ItemId;
            itemInInventory1.ItemName = itemInInventory2.ItemName;
            itemInInventory1.Quantity = itemInInventory2.Quantity;
            itemInInventory1.Price = itemInInventory2.Price;

            itemInInventory2.ItemId = tempId;
            itemInInventory2.ItemName = tempName;
            itemInInventory2.Quantity = tempQty;
            itemInInventory2.Price = tempPrice;
        }
    }
}
