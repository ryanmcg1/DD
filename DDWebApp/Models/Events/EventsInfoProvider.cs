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
            DataSet ds = null; ;// = DatabaseProvider.ReturnDataset("SELECT * FROM Event WHERE EventID =" + ID);

            if (ds != null)
            {
                   return new EventInfo(ds.Tables[0].Rows[0]);
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
            DataSet ds =null;// = DatabaseProvider.ReturnDataset(sql);

            if (ds != null)
            {
                List<EventInfo> EventList = new List<EventInfo>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    EventList.Add(new EventInfo(dr));
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
