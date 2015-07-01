using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DDWebApp.Models.Venue;
using DDWebApp.Models.Database;


namespace DDWebApp.Models.Venue
{
    /// <summary>
    /// Summary description for VenueInfoProvider
    /// </summary>
    public static class VenueInfoProvider
    {

        public static VenueInfo GetVenueById(int ID)
        {
            DataSet ds =null;// = DatabaseProvider.ReturnDataset("SELECT * FROM Venue WHERE VenueID =" + ID);

            if (ds != null)
            {
                return new VenueInfo(ds.Tables[0].Rows[0]);
            }
            else
            {
                return new VenueInfo();
            }
        }

        public static List<VenueInfo> GetVenues()
        {
            return GetVenues("");
        }


        public static List<VenueInfo> GetVenues(string where)
        {
            if (where != "")
                where = " WHERE " + where;

            string sql = string.Format("SELECT * FROM Venue {0}", where);

            //Get DS
            DataSet ds =null;// = DatabaseProvider.ReturnDataset(sql);

            if (ds != null)
            {
                List<VenueInfo> venueList = new List<VenueInfo>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    venueList.Add(new VenueInfo(dr));
                }
                return venueList;
            }
            else
            {
                return new List<VenueInfo>();
            }
        }
    }
}
