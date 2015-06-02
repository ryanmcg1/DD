using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Owin;
using DDWebApp.Models.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;


namespace DDWebApp.Templates.website.User
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<MyUserManager>();
            var signInManager = Context.GetOwinContext().Get<MySignInManager>();
            var result = signInManager.PasswordSignIn(txtUsername.Text,txtPassword.Text,chkRememberMe.Checked,false);

            switch (result)
            {
                case SignInStatus.Success:
                    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                    break;
                case SignInStatus.LockedOut:
                    Response.Redirect("/Templates/Website/User/banned");
                    break;
                case SignInStatus.RequiresVerification:
                    Response.Redirect(String.Format("/Templates/Website/User/TwoFactorAuthenticationSignIn?ReturnUrl={0}&RememberMe={1}",
                                                    Request.QueryString["ReturnUrl"],
                                                    chkRememberMe.Checked),
                                      true);
                    break;
                case SignInStatus.Failure:
                    ltlMessage.Text = "Username or password was invalid.";
                    break;
                default:
                    ltlFailureText.Text = "Invalid login attempt";
                    ltlErrorMessage.Visible = true;
                    break;
            }
        }
    }
}