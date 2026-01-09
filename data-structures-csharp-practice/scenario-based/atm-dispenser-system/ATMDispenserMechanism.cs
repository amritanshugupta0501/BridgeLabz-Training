using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.atmdispenser
{
    internal class ATMDispenserMechanism
    {
        AmountRetrieve Head;
        // Scenario 1 : Optimal combo for amount dispenser machine for a given amount
        public void InitiateAmountRetrieving(int amount)
        {
            AmountRetrieve head = null;
            int[] notesPresent = new int[] { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
            Array.Sort(notesPresent);
            int index = notesPresent.Length - 1;
            for (int moneyNote = index; moneyNote >= 0; moneyNote--)
            {
                while (amount >= notesPresent[moneyNote])
                {
                    AmountRetrieve amountRetrieve = new AmountRetrieve(notesPresent[moneyNote]);
                    amount -= notesPresent[moneyNote];
                    if (head == null)
                    {
                        head = amountRetrieve;
                    }
                    else
                    {
                        AmountRetrieve current = head;
                        while (current.Next != null)
                        {
                            current = current.Next;
                        }
                        current.Next = amountRetrieve;
                    }
                }
                if (amount == 0)
                {
                    Head = head;
                    return;
                }
            }
            Console.WriteLine(FallbackCombo(amount));
        }
        // Scenario 2 : Optimal combo after removing the 500 currency note
        public void InitiateAmountRetrievingAfterRemoving500(int amount)
        {
            AmountRetrieve head = null;
            int[] notesPresent = new int[] { 1, 2, 5, 10, 20, 50, 100, 200 };
            Array.Sort(notesPresent);
            int index = notesPresent.Length - 1;
            for (int moneyNote = index; moneyNote >= 0; moneyNote--)
            {
                while (amount >= notesPresent[moneyNote])
                {
                    AmountRetrieve amountRetrieve = new AmountRetrieve(notesPresent[moneyNote]);
                    amount -= notesPresent[moneyNote];
                    if (head == null)
                    {
                        head = amountRetrieve;
                    }
                    else
                    {
                        AmountRetrieve current = head;
                        while (current.Next != null)
                        {
                            current = current.Next;
                        }
                        current.Next = amountRetrieve;
                    }
                }
                if (amount == 0)
                {
                    Head = head;
                    return;
                }
            }
            Console.WriteLine(FallbackCombo(amount));
        }
        // Scenario 3 : Fall Back Combo Display if the amount can't be retrieved
        public string FallbackCombo(int amount)
        {
            if(amount == 0)
            {
                return "Optimal Combo Achieved!";
            }
            return $"{amount} change left.";
        }
        // Function to display the Optimal combo acheived
        public void DisplayComboRetrieved()
        {
            Console.WriteLine("Amount Dispensed : ");
            AmountRetrieve current = Head;
            while(current != null)
            {
                Console.WriteLine(current.ToString());
                current = current.Next;
            }
        }
    }
}
