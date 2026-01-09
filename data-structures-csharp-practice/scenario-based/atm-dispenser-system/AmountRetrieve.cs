using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.atmdispenser
{
    // Amount node for the combo list
    internal class AmountRetrieve
    {
        int Amount;
        public AmountRetrieve Next;
        public AmountRetrieve(int amount)
        {
            Amount = amount;
            Next = null;
        }
        public override string? ToString()
        {
            return $"Amount Retrieve : {Amount}";
        }
    }
}
