using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.atmdispenser
{
    // Entry point of the application
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount : ");
            ATMDispenserMechanism dispenserMechanism = new ATMDispenserMechanism();
            int amount = int.Parse(Console.ReadLine());
            dispenserMechanism.InitiateAmountRetrieving(amount);
            dispenserMechanism.DisplayComboRetrieved();
            dispenserMechanism.InitiateAmountRetrievingAfterRemoving500Currency(amount);
            dispenserMechanism.DisplayComboRetrieved();

        }
    }
}
