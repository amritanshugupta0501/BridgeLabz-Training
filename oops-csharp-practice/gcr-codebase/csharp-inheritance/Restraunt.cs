using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    // Interface for staff responsibilities
    interface IJobRole
    {
        void ExecuteDuty();
    }

    // Base class for the establishment
    class DiningVenue
    {
        public string VenueName;
        public int RegistrationNo;

        public DiningVenue(string vName, int regNo)
        {
            VenueName = vName;
            RegistrationNo = regNo;
        }
    }

    // Chef class inherits from DiningVenue and implements IJobRole
    class HeadChef : DiningVenue, IJobRole
    {
        public HeadChef(string vName, int regNo) : base(vName, regNo) { }

        public void ExecuteDuty()
        {
            Console.WriteLine("Role: HeadChef is preparing the dishes.");
        }
    }

    // Waiter class inherits from DiningVenue and implements IJobRole
    class ServerStaff : DiningVenue, IJobRole
    {
        public ServerStaff(string vName, int regNo) : base(vName, regNo) { }

        public void ExecuteDuty()
        {
            Console.WriteLine("Role: ServerStaff is attending to customers.");
        }
    }
}