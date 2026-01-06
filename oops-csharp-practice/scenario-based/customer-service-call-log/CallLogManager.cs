using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.customer_service_call_log
{
    internal class CallLogManager : ICallLogManager
    {
        private CallLogs[] Logs;
        private int LogCount;
        public CallLogManager(int initialCapacity = 50)
        {
            Logs = new CallLogs[initialCapacity];
            LogCount = 0;
        }
        public void AddCallLog(string phone, string message)
        {
            if(LogCount == Logs.Length)
            {
                ResizeArray();
            }
            Logs[LogCount] = new CallLogs(phone, message, DateTime.Now);
            LogCount++;
        }
        public void ResizeArray()
        {
            CallLogs[] newArray = new CallLogs[Logs.Length * 2];
            for (int loop = 0; loop < newArray.Length; loop++)
            {
                newArray[loop] = Logs[loop];
            }
            Logs = newArray;
        }
        public CallLogs[] SearchByKeyword(string keyword)
        {
            int matchCount = 0;
            for (int loop = 0; loop < LogCount; loop++)
            {
                if (Logs[loop].Message.ToLower().Contains(keyword.ToLower()))
                {
                    matchCount++;
                }
            }
            CallLogs[] results = new CallLogs[matchCount];
            int index = 0;
            for (int loop = 0; loop < LogCount; loop++)
            {
                if (Logs[loop].Message.ToLower().Contains(keyword.ToLower()))
                {
                    results[index] = Logs[loop];
                    index++;
                }
            }
            return results;
        }
        public CallLogs[] FilterByTime(DateTime start, DateTime end)
        {
            int matchCount = 0;
            for(int loop = 0; loop<LogCount; loop++)
            {
                if (Logs[loop].Timestamp >= start && Logs[loop].Timestamp <= end)
                {
                    matchCount++;
                }
            }
            CallLogs[] results = new CallLogs[matchCount];
            int index = 0;
            for(int loop = 0; loop<LogCount; loop++)
            {
                if(Logs[loop].Timestamp >= start &&Logs[loop].Timestamp <= end)
                {
                    results[index] = Logs[loop];
                    index++;
                }
            }
            return results;
        }
        public void DisplayLogs(CallLogs[] displayLogs)
        {
            if (displayLogs.Length == 0)
            {
                Console.WriteLine("No logs Found.");
                return;
            }
            foreach (CallLogs log in displayLogs)
            {
                Console.WriteLine(log.ToString());
            }
        }

    }
}
