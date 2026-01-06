using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.customer_service_call_log
{
    internal class CallLogs
    {
        public string Name {  get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public CallLogs(string name, string phoneNumber, string text, DateTime time) 
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Message = text;
            Timestamp = time;
        }
        public override string ToString()
        {
            return $"[{Timestamp}] : {Name} : {Message}";
        }
    }
}
