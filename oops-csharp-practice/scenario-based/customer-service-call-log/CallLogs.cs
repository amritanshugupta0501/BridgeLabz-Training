using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.customer_service_call_log
{
    internal class CallLogs
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public CallLogs(string phoneNumber, string text, DateTime time) 
        {
            PhoneNumber = phoneNumber;
            Message = text;
            Timestamp = time;
        }
        public override string ToString()
        {
            return $"[{Timestamp}] : {PhoneNumber} : {Message}";
        }
    }
}
