using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDWebApp.Models.Log
{
    public abstract class Logs
    {
        public abstract void WriteToLog(string message);

        public abstract void DeleteFromLog(int id);
        public abstract void ClearLog();

    }
}