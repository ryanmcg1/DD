using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DDWebApp.Models.Event;
using System.Globalization;
using DDWebApp.Models.EventInfoProvider;

namespace DDWebApp.Templates.website.Admin.Events
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            rptEvents.DataSource= EventInfoProvider.GetEvents();
            rptEvents.DataBind();
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            EventInfo dd = new EventInfo();
            dd.EventName = txtEventName.Text;
            dd.EventDate = DateTime.ParseExact(txtEventDate.Text,"d/M/yyyy",CultureInfo.InvariantCulture);
            
            if(dd.SaveEvent())
            {
                lblMessage.Text = "Succcesfully added " + dd.EventName;
                txtEventName.Text = "";
                //txtEventDate.Text = "";
            }
            else
            {
                lblError.Text = "error";
            }

            rptEvents.DataSource = EventInfoProvider.GetEvents();
            rptEvents.DataBind();
        }


        
      
    }
}