using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using DDWebApp.Models.MessageEventArgInfo;
using DDWebApp.Models.Database;
using DDWebApp.Models.Logger;
using System.Data;


namespace DDWebApp.Models.Event
{
    public class EventInfo
    {
        public event EventHandler<MessageEventArgs> OnSaveEvent;

        public int EventID {get; set;}
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public bool EventIsPublished { get; set; }

        public string EventDescription { get; set; }
        public string EventNotes1 { get; set; }
        public string EventNotes2 { get; set; }
        public DateTime CreationTimeStamp { get;  set; }
        public DateTime UpdateTimeStamp { get;  set; }
       
        public EventInfo()
        {

        }

        public EventInfo(DataRow dr)
        {
            this.EventID = int.Parse(dr["EventID"].ToString());
            this.EventName = dr["EventName"].ToString();
            this.CreationTimeStamp = dr.Field<DateTime>("CreationTimeStamp");
            this.EventDate = dr.Field<DateTime>("EventDate");
            this.EventDescription = dr["EventDescription"].ToString();
            this.EventIsPublished = (bool)dr["EventIsPublished"];
        }
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
               
                this.OnSaveEvent += LogInfo.OnEvent;
                
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