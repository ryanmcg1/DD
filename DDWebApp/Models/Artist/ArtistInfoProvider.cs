using DDWebApp.Models.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DDWebApp.Models.Artist
{
    public class ArtistInfoProvider
    {

        public static ArtistInfo GetArtistById(int ID)
        {
            DataSet ds = DatabaseProvider.ReturnDataset("SELECT top 1 * FROM artist WHERE ArtistID =" + ID);

            if (ds != null)
            {
                ArtistInfo artist = new ArtistInfo();
                artist.ArtistName = ds.Tables[0].Rows[0]["ArtistName"].ToString();
                artist.ArtistPhoneNumber = ds.Tables[0].Rows[0]["ArtistPhoneNumber"].ToString();
                artist.ArtistWebsite = ds.Tables[0].Rows[0]["ArtistWebsite"].ToString();
                artist.ArtistEmail = ds.Tables[0].Rows[0]["ArtistEmail"].ToString();
                return artist;
            }
            else
            {
                return new ArtistInfo();
            }
        }

        public static List<ArtistInfo> GetArtist()
        {
            string sql = string.Format("SELECT * FROM Artist");

            //Get DS
            DataSet ds = DatabaseProvider.ReturnDataset(sql);

            if (ds != null)
            {
                List<ArtistInfo> artistList = new List<ArtistInfo>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ArtistInfo artist = new ArtistInfo();
                    artist.ArtistName = dr["ArtistName"].ToString();
                    artist.ArtistPhoneNumber = dr["ArtistPhoneNumber"].ToString();
                    artist.ArtistWebsite = dr["ArtistWebsite"].ToString();
                    artist.ArtistEmail = dr["ArtistEmail"].ToString();
                    artistList.Add(artist);
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