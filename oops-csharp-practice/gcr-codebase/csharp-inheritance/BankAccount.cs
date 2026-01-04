using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    // Base account class
    internal class MoneyAccount
    {
        public int AccId;
        public double TotalFunds;

        public MoneyAccount(int id, double funds)
        {
            AccId = id;
            TotalFunds = funds;
        }

        public virtual void IdentifyType()
        {
            Console.WriteLine("Standard Bank Account");
        }
    }

    // Class for savings
    class DepositAccount : MoneyAccount
    {
        public double Rate;

        public DepositAccount(int id, double funds, double r)
            : base(id, funds)
        {
            Rate = r;
        }

        public override void IdentifyType()
        {
            Console.WriteLine("Type: Savings Account");
        }
    }

    // Class for checking
    class CurrentAccount : MoneyAccount
    {
        public int DailyLimit;

        public CurrentAccount(int id, double funds, int limit)
            : base(id, funds)
        {
            DailyLimit = limit;
        }

        public override void IdentifyType()
        {
            Console.WriteLine("Type: Checking Account");
        }
    }
}