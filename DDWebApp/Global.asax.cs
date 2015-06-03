using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace DDWebApp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterRoutes(RouteTable.Routes);
        }

        void RegisterRoutes(RouteCollection routes)
        {
            //Admin
            routes.MapPageRoute("Admin", "Admin/Users", "~/Templates/Website/Admin/Users/Users.aspx");
            routes.MapPageRoute("Admin", "Admin/Events", "~/Templates/Website/Admin/Events/Events.aspx");
            routes.MapPageRoute("Admin", "Admin/Venues", "~/Templates/Website/Admin/Venues/Venues.aspx");
            routes.MapPageRoute("Admin", "Admin/Roles", "~/Templates/Website/Admin/Roles/Roles.aspx");
            routes.MapPageRoute("Admin", "Admin/UserRoles", "~/Templates/Website/Admin/UserRoles/UserRoles.aspx");
            routes.MapPageRoute("Admin", "Admin/Artists", "~/Templates/Website/Admin/Artists/Artists.aspx");
            //Users
            routes.MapPageRoute("User", "User", "~/Templates/Website/User/User.aspx");
            routes.MapPageRoute("User", "Login", "~/Templates/Website/User/Login.aspx");
            routes.MapPageRoute("User", "Register", "~/Templates/Website/User/Register.aspx");

            //Events
            routes.MapPageRoute("Events", "Events", "~/Templates/Website/Events/Events.aspx");
            routes.MapPageRoute("Events", "Events/Add", "~/Templates/Website/Events/EventAdd.aspx");
            routes.MapPageRoute("Events", "Events/Edit", "~/Templates/Website/Events/EventEdit.aspx");

            //Venues
            routes.MapPageRoute("Venues", "Venues", "~/Templates/Website/Venues/Venues.aspx");
            routes.MapPageRoute("Venues", "Venues/Add", "~/Templates/Website/Venues/VenuesAdd.aspx");
            routes.MapPageRoute("Venues", "Venues/Edit", "~/Templates/Website/Venues/VenuesEdit.aspx");

            //Artist
            routes.MapPageRoute("Artists", "Artists", "~/Templates/Website/Artists/Artists.aspx");
            routes.MapPageRoute("Artists", "Artists/Add", "~/Templates/Website/Artists/ArtistsAdd.aspx");
            routes.MapPageRoute("Artists", "Artists/Edit", "~/Templates/Website/Artists/ArtistsEdit.aspx");
            //routes.MapPageRoute("Admin", "", "~/Templates/Website/F.aspx");



            //routes.MapPageRoute("Admin", "", "~/Templates/Website/Admin/.aspx");

        }

    }
}