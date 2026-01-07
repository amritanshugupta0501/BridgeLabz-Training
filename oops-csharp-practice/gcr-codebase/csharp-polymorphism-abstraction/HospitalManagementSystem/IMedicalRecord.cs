using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.HospitalManagementSystem
{
    internal interface IMedicalRecord
    {
        void AddRecord(string diagnosis);
        void ViewRecords();
    }
}
