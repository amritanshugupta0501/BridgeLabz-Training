using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.customer_service_call_log
{
    internal interface ICallLogManager
    {
        void AddCallLog(string phone, string message);
        void ResizeArray();
        CallLogs[] SearchByKeyword(string keyword);
        CallLogs[] FilterByTime(DateTime start, DateTime end);
        void DisplayLogs(CallLogs[] displayLogs);


    }
}
