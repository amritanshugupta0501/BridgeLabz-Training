using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.AadharNumbersSorter
{
    internal class AadharInformation
    {
        string PersonName;
        string PersonAddress;
        long AadharNumber;
        public AadharInformation Next;

        public string PersonName1 { get => PersonName; set => PersonName = value; }
        public string PersonAddress1 { get => PersonAddress; set => PersonAddress = value; }
        public long AadharNumber1 { get => AadharNumber; set => AadharNumber = value; }

        public override string? ToString()
        {
            return $"Person Name : {PersonName1}\nPerson Address : {PersonAddress1}\nAadhar Number : {AadharNumber1}";
        }
    }
}
