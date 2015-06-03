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
using DDWebApp.Models.Roles;


namespace DDWebApp.Templates.website.Admin.Roles
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            gvRoles.DataSource = RoleInfoProvider.GetRoles(Context);
            gvRoles.DataBind();
        }

        protected void btnAddRole_Click(object sender, EventArgs e)
        {
            var roleManager = Context.GetOwinContext().Get<MyRoleManager>();

            //Create Role Admin if it does not exist
            var role = roleManager.FindByName(txtRoleName.Text);
            if (role == null)
            {
                role = new MyRole(txtRoleName.Text, txtRoleDescription.Text);
                //role.Id = 1; // this will be integer

                IdentityResult roleresult = roleManager.Create(role);
                if(roleresult.Succeeded)
                {
                    gvRoles.DataSource = RoleInfoProvider.GetRoles(Context);
                    gvRoles.DataBind();
                    ltlMessage.Text = "Role Added.";
                }
                else
                {
                    foreach(string res in roleresult.Errors )
                    ltlMessage.Text += res;
                }

            }
            else
            {
                ltlMessage.Text = "Role already exists.";
            }
        }        
    }
}