using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDWebApp.Models.Log
{
    public abstract class Logs
    {

        public enum MessageType
        {
            /// <value>Informational message</value>
            Informational = 1,
            /// <value>Failure audit message</value>
            Failure = 2,
            /// <value>Warning message</value>
            Warning = 3,
            /// <value>Error message</value>
            Error = 4
        }

        public abstract void WriteToLog(string message, MessageType Severity);
        public abstract void WriteToLog(Exception message, MessageType Severity);

        public abstract void DeleteFromLog(int id);
        public abstract void ClearLog();

    }
}