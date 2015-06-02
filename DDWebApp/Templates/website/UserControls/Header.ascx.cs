using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DDWebApp.Templates.website.UserControls
{
    public partial class Header : System.Web.UI.UserControl
    {
        public string UserName { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Context.User.Identity.Name != "")
            {
                UserName = "Welcome back, " + Context.User.Identity.Name;
                pnlUserInfo.Visible = true;
            }

        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            var AuthManager = HttpContext.Current.GetOwinContext().Authentication;
            AuthManager.SignOut();
            Response.Redirect(Request.RawUrl);
        }
    }
}