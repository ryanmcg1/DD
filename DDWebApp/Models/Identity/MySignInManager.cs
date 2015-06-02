using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;
using Microsoft.Owin;
using System.Threading.Tasks;

namespace DDWebApp.Models.Identity
{
    public class MySignInManager : SignInManager<MyUser,long>
    {

        public MySignInManager(MyUserManager userManager, IAuthenticationManager authenticationManager)
        : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(MyUser user)
        {
            return user.GenerateUserIdentityAsync((MyUserManager)UserManager);
        }

        public static MySignInManager Create(IdentityFactoryOptions<MySignInManager> options, IOwinContext context)
        {
            return new MySignInManager(context.GetUserManager<MyUserManager>(), context.Authentication);
        }
    }
}