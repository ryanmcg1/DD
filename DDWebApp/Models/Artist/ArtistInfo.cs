using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using DDWebApp.Models.MessageEventArgInfo;
using DDWebApp.Models.Database;
using DDWebApp.Models.Logger;
using System.Data;
using System.Reflection;


namespace DDWebApp.Models.Artist
{
    public class ArtistInfo
    {
        public event EventHandler<MessageEventArgs> OnSaveArtist;
        #region DB Properties
        [SkipProperty]
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string ArtistAddress1 { get; set; }
        public string ArtistAddress2 { get; set; }
        public string ArtistAddress3 { get; set; }
        public string ArtistPostCode { get; set; }
        public string ArtistPhoneNumber { get; set; }
        public string ArtistWebsite { get; set; }
        public string ArtistEmail { get; set; }
        public string ArtistNotes1 { get; set; }
        public string ArtistNotes2 { get; set; }
        public bool ArtistIsPublished { get; set; }
        [SkipProperty]
        public DateTime? CreationTimeStamp { get; set; }
        [SkipProperty]
        public DateTime? UpdateTimeStamp { get; set; } 
        #endregion

        const string TableName = "Artist";
        
        public ArtistInfo()
        {
            this.ArtistID = 0;
            this.ArtistName = "";
            this.ArtistPhoneNumber = "";
            this.ArtistWebsite = "";
            this.ArtistEmail = "";
            this.ArtistAddress1 = "";
            this.ArtistAddress2 = "";
            this.ArtistAddress3 = "";
            this.ArtistPostCode = "";
            this.ArtistIsPublished = false;
            this.ArtistNotes1 = "";
            this.ArtistNotes2 = "";
            this.CreationTimeStamp = DateTime.Now ;
            this.UpdateTimeStamp = DateTime.Now;
        }

        public ArtistInfo(DataRow dr)
        {
            this.ArtistID = int.Parse(dr["ArtistID"].ToString());
            this.ArtistName = dr["ArtistName"].ToString();
            this.ArtistPhoneNumber = dr["ArtistPhoneNumber"].ToString();
            this.ArtistWebsite = dr["ArtistWebsite"].ToString();
            this.ArtistEmail = dr["ArtistEmail"].ToString();
            this.ArtistAddress1 = dr["ArtistAddress1"].ToString();
            this.ArtistAddress2 = dr["ArtistAddress2"].ToString();
            this.ArtistAddress3 = dr["ArtistAddress3"].ToString();
            this.ArtistPostCode = dr["ArtistPostCode"].ToString();
            this.ArtistIsPublished = (bool)dr["ArtistIsPublished"];
            this.ArtistNotes1 = dr["ArtistNotes1"].ToString();
            this.ArtistNotes2 = dr["ArtistNotes2"].ToString();
            this.CreationTimeStamp = dr.Field<DateTime?>("CreationTimeStamp");
            this.UpdateTimeStamp = dr.Field<DateTime?>("UpdateTimeStamp");
        }

        public bool SaveArtist()
        {
            //Log event
            this.OnSaveArtist += DBLog.OnEvent;

            Dictionary<string, object> parameterList = new Dictionary<string, object>();
            foreach (var propertyInfo in this.GetType().GetProperties().Where(pi => !Attribute.IsDefined(pi, typeof(SkipPropertyAttribute))))
            {
                parameterList.Add(propertyInfo.Name, propertyInfo.GetValue(this,null).ToString());
            }

            //Execute sqlcommand
            DatabaseProvider DBP = new DatabaseProvider();
            bool result = DBP.ExecuteStoredProc(parameterList, "sp_InsertArtist");
            OnSaveArtistEvent("Artist saved:" + this.ArtistName + "-" + result);
            return result;

            //cmd.Parameters.AddWithValue("@ArtistName", this.ArtistName);
            //cmd.Parameters.AddWithValue("@ArtistWebsite", this.ArtistWebsite);
            //cmd.Parameters.AddWithValue("@ArtistPhoneNumber", this.ArtistPhoneNumber);
            //cmd.Parameters.AddWithValue("@ArtistEmail", this.ArtistEmail);
            //cmd.Parameters.AddWithValue("@ArtistAddress1", this.ArtistAddress1);
            //cmd.Parameters.AddWithValue("@ArtistAddress2", this.ArtistAddress2);
            //cmd.Parameters.AddWithValue("@ArtistAddress3", this.ArtistAddress3);
            //cmd.Parameters.AddWithValue("@ArtistPostCode", this.ArtistPostCode);
            //cmd.Parameters.AddWithValue("@ArtistNotes1", this.ArtistNotes1);
            //cmd.Parameters.AddWithValue("@ArtistNotes2", this.ArtistNotes2);
            //cmd.Parameters.AddWithValue("@ArtistIsPublished", this.ArtistIsPublished);   

            
        }

        protected virtual void OnSaveArtistEvent(string message)
        {
            if (OnSaveArtist != null)
                OnSaveArtist(this, new MessageEventArgs(message));
        }
    }
}