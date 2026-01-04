using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    // Root class
    class PurchaseRequest
    {
        public int RequestId;
        public string DateCreated;

        public PurchaseRequest(int id, string date)
        {
            RequestId = id;
            DateCreated = date;
        }

        public virtual void ShowTracking()
        {
            Console.WriteLine("Status: Order Confirmed");
        }
    }

    // Intermediate class
    class DispatchedItem : PurchaseRequest
    {
        public string TrackingId;

        public DispatchedItem(int id, string date, string track)
            : base(id, date)
        {
            TrackingId = track;
        }

        public override void ShowTracking()
        {
            Console.WriteLine("Status: In Transit");
        }
    }

    // Final subclass
    class CompletedItem : DispatchedItem
    {
        public string ArrivalDate;

        public CompletedItem(int id, string date, string track, string arrival)
            : base(id, date, track)
        {
            ArrivalDate = arrival;
        }

        public override void ShowTracking()
        {
            Console.WriteLine($"Status: Delivered on {ArrivalDate}");
        }
    }

    class Program
    {
        static void Main()
        {
            PurchaseRequest pr = new CompletedItem(101, "10-Jan", "TRK123", "15-Jan");
            pr.ShowTracking();
        }
    }
}