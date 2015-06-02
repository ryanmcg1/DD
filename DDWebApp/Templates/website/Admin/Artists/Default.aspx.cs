using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DDWebApp.Models.Artist;

namespace DDWebApp.Templates.website.Admin.Artists
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ArtistInfo> enlist = ArtistInfoProvider.GetArtist();

            rptArtist.DataSource = enlist;
            rptArtist.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ArtistInfo artist = new ArtistInfo();

            artist.ArtistName = txtArtistName.Text;
            artist.ArtistPhoneNumber = txtArtistPhoneNumber.Text;
            artist.ArtistWebsite = txtArtistWebsite.Text;
            artist.ArtistEmail = txtArtistEmail.Text;
            
            if(artist.SaveArtist())
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