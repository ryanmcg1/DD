using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDWebApp.Models.Log
{
    public class NLog : Logs
    {

            //Logger log = LogManager.GetCurrentClassLogger();
            //log.Info("test");
        

        public override void DeleteFromLog(int id)
        {
            throw new NotImplementedException();
        }

        public override void ClearLog()
        {
            throw new NotImplementedException();
        }

        public override void WriteToLog(string message, Logs.MessageType Severity)
        {
            throw new NotImplementedException();
        }

        public override void WriteToLog(Exception message, Logs.MessageType Severity)
        {
            throw new NotImplementedException();
        }
    }
}