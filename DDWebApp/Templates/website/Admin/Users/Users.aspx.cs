using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DDWebApp.Models.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using DDWebApp.Models.Users;
using DDWebApp.Models.Logger;

namespace DDWebApp.Templates.website.Admin.Users
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            gvUserList.DataSource = UserInfoProvider.GetUsers(Context);
            gvUserList.DataBind();

        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            MyUserManager userManager = Context.GetOwinContext().Get<MyUserManager>();
            MyUser user = new MyUser()
            {
                UserName = txtUserEmail.Text,
                Email = txtUserEmail.Text
            };

            IdentityResult result = null;
            try
            {
                result = userManager.Create(user, txtUserPassword.Text);
            }
            catch (Exception exec)
            {
                DBLog logInfo = new DBLog();
                logInfo.WriteToLog(exec.Message);
                logInfo.WriteToLog(exec.InnerException.Message);
            }
            

            if (result.Succeeded)
            {
                ltlMessage.Text = "User added.<br/>";
                gvUserList.DataSource = UserInfoProvider.GetUsers(Context);
                gvUserList.DataBind();
            }
            else
            {
                ltlError.Text = result.Errors.FirstOrDefault();
            }
        }        

    }
}