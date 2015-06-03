using DDWebApp.Models.Identity;
using DDWebApp.Models.Roles;
using DDWebApp.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace DDWebApp.Templates.website.Admin.UserRoles
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            MyUserManager userManager = Context.GetOwinContext().Get<MyUserManager>();
            userManager.AddToRole(18, "User");
            List<MyUser> userList = UserInfoProvider.GetUsers(Context);
            foreach (MyUser user in userList)
            {
                drpUserRoleUser.Items.Add(new ListItem(user.UserName, user.Id.ToString()));
            }
           
            List<MyRole> roles = RoleInfoProvider.GetRoles(Context);
            foreach (MyRole role in roles)
            {
                chkUserRoleRole.Items.Add(new ListItem(role.Name, role.Id.ToString()));
            }
            chkUserRoleRole.DataBind();

        }

        protected void btnAddUserRole_Click(object sender, EventArgs e)
        {
            MyUserManager userManager = Context.GetOwinContext().Get<MyUserManager>();

            string[] Roles;
            Roles = chkUserRoleRole.Items.Cast<ListItem>().Where(i => i.Selected).Select(i => i.ToString()).ToArray();

            long UserID = int.Parse(drpUserRoleUser.SelectedValue);
            var results = userManager.AddToRoles(UserID, Roles);

            if(results.Succeeded)
            {
                ltlMessage.Text = "User added to role(s): <br/>";
                foreach(string role in Roles)
                {
                    ltlMessage.Text += role + "<br/>";
                }
            }
            else
            {
                foreach(string error in results.Errors)
                {
                    ltlMessage.Text += error + "</br>";
                }
            }
        }
    }
}