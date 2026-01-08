using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.smarthomeautomationsystem
{
    // Interface to implement the given methods for an appliance
    internal interface IControllable
    {
        void TurnOn();
        void TurnOff();
    }
}
