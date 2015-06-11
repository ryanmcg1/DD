using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using DDWebApp.Models.MessageEventArgInfo;
using DDWebApp.Models.Database;
using DDWebApp.Models.Logger;


namespace DDWebApp.Models.Event
{
    public class EventInfo
    {
        public event EventHandler<MessageEventArgs> OnSaveEvent;

        
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventDateCreated { get; set; }

        public bool EventIsPublished { get; set; }

        public string EventDescription { get; set; }
       
        public bool SaveEvent()
        {
            //iF Edit ... todo
            using (SqlCommand cmd = new SqlCommand())
            {
                //cmd.CommandText = "INSERT INTO Event(EventName,EventDate)VALUES(@EventName,@EventDate)"
                cmd.Parameters.AddWithValue("@EventName", EventName);
                cmd.Parameters.AddWithValue("@EventDate", EventDate);
                cmd.Parameters.AddWithValue("@EventDescription", EventDescription);
                cmd.Parameters.AddWithValue("@EventIsPublished", EventIsPublished);

                DatabaseProvider DBP = new DatabaseProvider();
                LogInfo logger = new LogInfo();

                this.OnSaveEvent += logger.OnEvent;
                
                //Execute SP
                bool result = DBP.ExecuteStoredProc(cmd,"sp_InsertEvent");
                OnSaveEventEvent("Event saved:" + EventName);
                return result;
            }
        }

        protected virtual void OnSaveEventEvent(string message)
        {
            if (OnSaveEvent != null)
                OnSaveEvent(this, new MessageEventArgs(message));
        }
    }   
}