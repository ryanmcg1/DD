using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DDWebApp.Models.Venue;

namespace DDWebApp.Templates.website.Admin.Venues
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string where = "";
            //if (IsPostBack)
            //{
            //    if (txtVenueName.Text != "")
            //    {
            //        where = "venueName='" + txtVenueName.Text + "'";
            //    }
            //}


            List<VenueInfo> enlist = VenueInfoProvider.GetVenues();

            //VenueInfo en = VenueInfoProvider.GetVenueById(1);

            rptVenue.DataSource = enlist;
            rptVenue.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            VenueInfo venue = new VenueInfo();

            venue.VenueName = txtVenueName.Text;
            venue.VenueEmail = txtVenueEmail.Text;
            venue.VenueWebsite = txtVenueWebsite.Text;
            if(venue.SaveVenue())
            {
                lblError.Text = "Success <br/>";

            }
            else
            {
                lblError.Text = "Failed";
            }

            

        }

    }
}