namespace DDWebApp.Models.Identity
{
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using DDWebApp.Models.MessageEventArgInfo;
    using DDWebApp.Models.DBLog;

    public class MyUser : IdentityUser<long, MyLogin, MyUserRole, MyClaim>
    {
       

        public event EventHandler<MessageEventArgs> OnSaveUser;

     
        public string PasswordAnswer { get; set; }

        public string PasswordQuestion { get; set; }

        public DateTime UserDateCreated { get { return DateTime.Now; } }

        private DateTime UserDateModified { get{return DateTime.Now;}}

        public DateTime UserLastLogin { get { return DateTime.Now; } }

        public bool UserIsBanned { get; set; }

   
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(MyUserManager userManager)
        {
            var userIdentity = await userManager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        
        protected virtual void OnSaveArtistEvent(string message)
        {
            if (OnSaveUser != null)
                OnSaveUser(this, new MessageEventArgs(message));
        }


        //public IdentityResult AddUser(string email, string password)
        //{
        //    MyUserManager
        //    var user = new MyUser()
        //    {
        //        UserName = email,
        //        Email = email
        //    };

        //    IdentityResult result = null;
        //    try
        //    {
        //        //result = UserManager.Create(user, password);
        //        return result;
        //    }
        //    catch (Exception exec)
        //    {
        //        LogInfo.WriteLog(exec.Message);
        //        LogInfo.WriteLog(exec.InnerException.Message);
        //    }
        //    return result;
        //}

    }
}