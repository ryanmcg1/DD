using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DDWebApp.Models.Event;
using DDWebApp.Models.Database;
using System;


namespace DDWebApp.Models.EventInfoProvider
{
    /// <summary>
    /// Summary description for EventInfoProvider
    /// </summary>
    public class EventInfoProvider
    {

        public static EventInfo GetEventById(int ID)
        {
            DataSet ds = DatabaseProvider.ReturnDataset("SELECT * FROM Event WHERE EventID =" + ID);

            if (ds != null)
            {
                EventInfo Event = new EventInfo();
                Event.EventName = ds.Tables[0].Rows[0]["EventName"].ToString();
                Event.EventDate = DateTime.Parse(ds.Tables[0].Rows[0]["EventWebsite"].ToString());
                return Event;
            }
            else
            {
                return new EventInfo();
            }
        }

        public static List<EventInfo> GetEvents()
        {
            return GetEvents("", "", 0);
        }
        public static List<EventInfo> GetEvents(string Where)
        {
            return GetEvents(Where, "", 0);
        }
        public static List<EventInfo> GetEvents(string Where,string Orderby)
        {
            return GetEvents(Where, Orderby, 0);
        }

        public static List<EventInfo> GetEvents(string Where,string OrderBy, int TopN)
        {
            string sql ="";

            if (TopN > 0)
            {
                sql = string.Format("SELECT top {0} * FROM Event",TopN);
            }
            else
            {
                sql = string.Format("SELECT * FROM Event");
            }
            
            if(Where !="")
                sql = sql + " Where " + Where ;

            if(OrderBy !="")
                sql = sql + " Order by " + OrderBy;
            

            //Get DS
            DataSet ds = DatabaseProvider.ReturnDataset(sql);

            if (ds != null)
            {
                List<EventInfo> EventList = new List<EventInfo>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    EventInfo Event = new EventInfo();
                    Event.EventName = dr["EventName"].ToString();
                    Event.EventDateCreated = dr.Field<DateTime>("EventDateCreated");
                    Event.EventDate = dr.Field<DateTime>("EventDate");
                    Event.EventDescription = dr["EventDescription"].ToString();
                    Event.EventIsPublished = (bool)dr["EventIsPublished"];

                    EventList.Add(Event);
                }
                return EventList;
            }
            else
            {
                return new List<EventInfo>();
            }
        }
    }
}
