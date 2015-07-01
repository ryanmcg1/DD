using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DDWebApp.Models;
using System.Data.SqlClient;
using DDWebApp.Models.MessageEventArgInfo;
using DDWebApp.Models.Database;
using DDWebApp.Models.Logger;
using System.Data;

namespace DDWebApp.Models.Venue
{
    public class VenueInfo
    {
        public event EventHandler<MessageEventArgs> OnSaveVenue;
        public string VenueName { get; set; }
        public string VenueWebsite { get; set; }
        public string VenueEmail { get; set; }
        
        public VenueInfo()
        {

        }

        public VenueInfo(DataRow dr)
        {
            this.VenueName = dr["VenueName"].ToString();
            this.VenueWebsite = dr["VenueWebsite"].ToString();
            this.VenueEmail = dr["VenueEmail"].ToString();
        }


        

        public bool SaveVenue()
        {
            //iF Edit ... todo
            using (SqlCommand cmd = new SqlCommand())
            {
                //cmd.CommandText = "INSERT INTO Venue(VenueName,VenueEmail,VenueWebsite)VALUES(@VenueName,@VenueEmail,@VenueWebsite)";
                cmd.Parameters.AddWithValue("@VenueName", VenueName);
                cmd.Parameters.AddWithValue("@VenueWebsite", VenueWebsite);
                cmd.Parameters.AddWithValue("@VenueEmail", VenueEmail);

                this.OnSaveVenue += DBLog.OnEvent;
                //Execute sqlcommand
                DatabaseProvider DBP = new DatabaseProvider();
                bool result=false;// = DBP.ExecuteStoredProc(cmd,"sp_InsertVenue");
                OnSaveVenueEvent("Venue saved:" + VenueName);
                return result;
            }
        }

        protected virtual void OnSaveVenueEvent(string message)
        {
            if (OnSaveVenue != null)
                OnSaveVenue(this, new MessageEventArgs(message));
        }
    }   
}