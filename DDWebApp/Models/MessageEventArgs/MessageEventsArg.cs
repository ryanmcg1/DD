using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDWebApp.Models.MessageEventArgInfo
{
    public class MessageEventArgs : EventArgs
    {
        public MessageEventArgs(string message)
        {
            this.message = message;
        }
        private readonly string message;
        public string Message { get { return message; } }
    }
}