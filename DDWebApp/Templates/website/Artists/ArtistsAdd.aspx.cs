using DDWebApp.Models.Artist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace DDWebApp.Templates.website.Artists
{
    public partial class ArtistsAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(User.Identity.IsAuthenticated)
            {
                Response.Write(User.Identity.IsAuthenticated.ToString());
            }
            int userId = int.Parse(User.Identity.GetUserId());
            ArtistInfo currentArtist = ArtistInfoProvider.GetArtistById(userId);

            lblError.Text += currentArtist;
            //rptArtist.DataSource = currentArtist;
            //rptArtist.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ArtistInfo artist = new ArtistInfo();

            artist.ArtistName = txtArtistName.Text;
            artist.ArtistPhoneNumber = txtArtistPhoneNumber.Text;
            artist.ArtistWebsite = txtArtistWebsite.Text;
            artist.ArtistEmail = txtArtistEmail.Text;

            if (artist.SaveArtist())
            {
                lblError.Text = "Success <br/>";
            }
            else
            {
                lblError.Text = "fail <br/>";
            }
        }
    }
}