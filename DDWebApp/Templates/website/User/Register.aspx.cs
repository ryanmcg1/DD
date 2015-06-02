using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DDWebApp.Models.Identity;
using Owin;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace DDWebApp.Templates.website.User
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ErrorMessage.Text = User.Identity.GetUserName() + "s";
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<MyUserManager>();
            var signInManager = Context.GetOwinContext().Get<MySignInManager>();
            var user = new MyUser() 
            {   UserName = txtUserName.Text,
                Email = txtUserName.Text
            };
            IdentityResult result = manager.Create(user, txtUserPassword.Text);
            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");
                signInManager.SignIn(user,  false,  false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else
            {
                ErrorMessage.Text = "Error: " + result.Errors.FirstOrDefault();
            }
        }
    }
}