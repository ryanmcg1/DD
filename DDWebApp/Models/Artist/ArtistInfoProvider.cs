using DDWebApp.Models.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DDWebApp.Models.Artist
{
    public class ArtistInfoProvider : ArtistInfo
    {

        public static ArtistInfo GetArtistById(int ID)
        {
            DataSet ds = DatabaseProvider.ReturnDataset("SELECT top 1 * FROM artist WHERE ArtistID =" + ID);

            if (ds != null)
            {
                return new ArtistInfo(ds.Tables[0].Rows[0]);
            }
            else
            {
                return new ArtistInfo();
            }
        }

        public static List<ArtistInfo> GetArtists()
        {
            return GetArtists("", "", 0);
        }

        public static List<ArtistInfo> GetArtists(string Where,String OrderBy, int TopN)
        {
            string sql = "";

            if (TopN > 0)
            {
                sql = string.Format("SELECT top {0} * FROM Artist", TopN);
            }
            else
            {
                sql = string.Format("SELECT * FROM Artist");
            }

            if (Where != "")
                sql = sql + " Where " + Where;

            if (OrderBy != "")
                sql = sql + " Order by " + OrderBy;

            //Get DS
            DataSet ds = DatabaseProvider.ReturnDataset(sql);

            if (ds != null)
            {
                List<ArtistInfo> artistList = new List<ArtistInfo>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    artistList.Add(new ArtistInfo(dr));
                }
                return artistList;
            }
            else
            {
                return new List<ArtistInfo>();
            }
        }

    }
}