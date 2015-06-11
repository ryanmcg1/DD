using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using DDWebApp.Models.MessageEventArgInfo;
using DDWebApp.Models.Database;
using DDWebApp.Models.Logger;


namespace DDWebApp.Models.Artist
{
    public class ArtistInfo
    {
        public event EventHandler<MessageEventArgs> OnSaveArtist;
        public string ArtistName { get; set; }
        public string ArtistPhoneNumber { get; set; }
        public string ArtistWebsite { get; set; }
        public string ArtistEmail { get; set; }
        
        public DateTime ArtistDateCreated { get; set; }


        public bool SaveArtist()
        {
            //iF Edit ... todo
            using (SqlCommand cmd = new SqlCommand())
            {
                //cmd.CommandText = "INSERT INTO Artist(ArtistName,ArtistWebsite,ArtistPhoneNumber,ArtistEmail)VALUES(@ArtistName,@ArtistWebsite,@ArtistPhoneNumber,@ArtistEmail)";
                cmd.Parameters.AddWithValue("@ArtistName", this.ArtistName);
                cmd.Parameters.AddWithValue("@ArtistWebsite", this.ArtistWebsite);
                cmd.Parameters.AddWithValue("@ArtistPhoneNumber", this.ArtistPhoneNumber);
                cmd.Parameters.AddWithValue("@ArtistEmail", this.ArtistEmail);

                DatabaseProvider DBP = new DatabaseProvider();
                LogInfo logger = new LogInfo();

                //Log event
                this.OnSaveArtist += logger.OnEvent;
                
                //Execute sqlcommand
                bool result = DBP.ExecuteStoredProc(cmd,"sp_InsertArtist");
                OnSaveArtistEvent("Artist saved:" + this.ArtistName + "-" + result);
                return result;
            }
        }

        protected virtual void OnSaveArtistEvent(string message)
        {
            if (OnSaveArtist != null)
                OnSaveArtist(this, new MessageEventArgs(message));
        }
    }
}