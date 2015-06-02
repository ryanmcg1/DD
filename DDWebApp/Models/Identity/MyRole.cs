namespace DDWebApp.Models.Identity
{
    using Microsoft.AspNet.Identity.EntityFramework;

    public class MyRole : IdentityRole<long,MyUserRole>
    {
        public MyRole()
        {
           
        }

        public MyRole(string name) : this(name, string.Empty)
        {
        }

        public MyRole(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public string Description { get; set; }
    }
}
