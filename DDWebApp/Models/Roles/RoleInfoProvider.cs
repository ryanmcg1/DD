using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using DDWebApp.Models.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;

namespace DDWebApp.Models.Roles
{
    public class RoleInfoProvider
    {
        public static List<MyRole> GetRoles(HttpContext Context)
        {
            var roleManager = Context.GetOwinContext().Get<MyRoleManager>();
            List<MyRole> roles = roleManager.Roles.ToList();

            return roles;
        }
    }
}