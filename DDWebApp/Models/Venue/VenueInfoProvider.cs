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
            DataSet ds = DatabaseProvider.ReturnDataset("SELECT * FROM Venue WHERE VenueID =" + ID);

            if (ds != null)
            {
                VenueInfo venue = new VenueInfo();
                venue.VenueName = ds.Tables[0].Rows[0]["VenueName"].ToString();
                venue.VenueWebsite = ds.Tables[0].Rows[0]["VenueWebsite"].ToString();
                venue.VenueEmail = ds.Tables[0].Rows[0]["VenueEmail"].ToString();
                return venue;
            }
            else
            {
                return new VenueInfo();
            }
        }

        public static List<VenueInfo> GetVenues()
        {
           string sql = string.Format("SELECT * FROM Venue");

            //Get DS
            DataSet ds = DatabaseProvider.ReturnDataset(sql);

            if (ds != null)
            {
                List<VenueInfo> venueList = new List<VenueInfo>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    VenueInfo venue = new VenueInfo();
                    venue.VenueName = dr["VenueName"].ToString();
                    venue.VenueWebsite = dr["VenueWebsite"].ToString();
                    venue.VenueEmail = dr["VenueEmail"].ToString();
                    venueList.Add(venue);
                }
                return venueList;
            }
            else
            {
                return new List<VenueInfo>();
            }
        }


        public static List<VenueInfo> GetVenues(string where)
        {
            if (where != "")
                where = " WHERE " + where;

            string sql = string.Format("SELECT * FROM Venue {0}", where);

            //Get DS
            DataSet ds = DatabaseProvider.ReturnDataset(sql);

            if (ds != null)
            {
                List<VenueInfo> venueList = new List<VenueInfo>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    VenueInfo venue = new VenueInfo();
                    venue.VenueName = dr["VenueName"].ToString();
                    venue.VenueWebsite = dr["VenueWebsite"].ToString();
                    venue.VenueEmail = dr["VenueEmail"].ToString();
                    venueList.Add(venue);
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
