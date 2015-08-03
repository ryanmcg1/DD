using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using DDWebApp.Models.MessageEventArgInfo;
using DDWebApp.Models.Database;
using DDWebApp.Models.DBLog;
using System.Data;


namespace DDWebApp.Models.Event
{
    public class EventInfo
    {
        public event EventHandler<MessageEventArgs> OnSaveEvent;

        public int EventID {get; set;}
        public string EventName { get; set; }
        public DateTime? EventDate { get; set; }
        public bool EventIsPublished { get; set; }

        public string EventDescription { get; set; }
        public string EventNotes1 { get; set; }
        public string EventNotes2 { get; set; }
        public DateTime? CreationTimeStamp { get;  set; }
        public DateTime? UpdateTimeStamp { get;  set; }
       
        public EventInfo()
        {

        }

        public EventInfo(DataRow dr)
        {
            this.EventID = int.Parse(dr["EventID"].ToString());
            this.EventName = dr["EventName"].ToString();
            this.EventDate = dr.Field<DateTime?>("EventDate");
            this.EventDescription = dr["EventDescription"].ToString();
            this.EventIsPublished = (bool)dr["EventIsPublished"];
            this.EventNotes1 = dr["EventNotes1"].ToString();
            this.EventNotes2 = dr["EventNotes2"].ToString();
            this.CreationTimeStamp = dr.Field<DateTime?>("CreationTimeStamp");
            this.UpdateTimeStamp = dr.Field<DateTime?>("UpdateTimeStamp");

        }
        public bool SaveEvent()
        {
            //iF Edit ... todo
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Parameters.AddWithValue("@EventName", EventName);
                cmd.Parameters.AddWithValue("@EventDate", EventDate);
                cmd.Parameters.AddWithValue("@EventDescription", EventDescription);
                cmd.Parameters.AddWithValue("@EventIsPublished", EventIsPublished);
                cmd.Parameters.AddWithValue("@EventNotes1", EventNotes1);
                cmd.Parameters.AddWithValue("@EventNotes2", EventNotes2);

                DatabaseProvider DBP = new DatabaseProvider();
               
                this.OnSaveEvent += DBLog.OnEvent;
                
                //Execute SP
                bool result=false;// = DBP.ExecuteStoredProc(cmd,"sp_InsertEvent");
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