using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using DDWebApp.Models.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;

namespace DDWebApp.Models.Users
{
    public static class UserInfoProvider
    {
       

        public static List<MyUser> GetUsers(HttpContext Context)
        {
            var userManager = Context.GetOwinContext().Get<MyUserManager>();

            List<MyUser> users = userManager.Users.ToList();

            return users;
        }
    }
}