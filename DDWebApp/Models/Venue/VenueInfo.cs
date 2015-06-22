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

        private string _VenueName;
        private string _VenueWebsite;
        private string _VenueEmail;

        public VenueInfo()
        {

        }

        public VenueInfo(DataRow dr)
        {
            this.VenueName = dr["VenueName"].ToString();
            this.VenueWebsite = dr["VenueWebsite"].ToString();
            this.VenueEmail = dr["VenueEmail"].ToString();
        }


        public string VenueName
        {
            get
            {
                return _VenueName;
            }

            set
            {
                _VenueName = value;
            }
        }

        public string VenueWebsite
        {
            get
            {
                return _VenueWebsite;
            }

            set
            {
                _VenueWebsite = value;
            }
        }


        public string VenueEmail
        {
            get
            {
                return _VenueEmail;
            }

            set
            {
                _VenueEmail = value;
            }
        }

        public bool SaveVenue()
        {
            //iF Edit ... todo
            using (SqlCommand cmd = new SqlCommand())
            {
                //cmd.CommandText = "INSERT INTO Venue(VenueName,VenueEmail,VenueWebsite)VALUES(@VenueName,@VenueEmail,@VenueWebsite)";
                cmd.Parameters.AddWithValue("@VenueName", _VenueName);
                cmd.Parameters.AddWithValue("@VenueWebsite", _VenueWebsite);
                cmd.Parameters.AddWithValue("@VenueEmail", _VenueEmail);

                DatabaseProvider DBP = new DatabaseProvider();
               
                this.OnSaveVenue += LogInfo.OnEvent;
                //Execute sqlcommand
                bool result = DBP.ExecuteQuery(cmd);
                OnSaveVenueEvent("Venue saved:" + _VenueName);
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