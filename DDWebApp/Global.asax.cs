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
            routes.MapPageRoute("AdminUsers", "Admin/Users", "~/Templates/Website/Admin/Users/Users.aspx");
            routes.MapPageRoute("AdminEvents", "Admin/Events", "~/Templates/Website/Admin/Events/Events.aspx");
            routes.MapPageRoute("AdminVenues", "Admin/Venues", "~/Templates/Website/Admin/Venues/Venues.aspx");
            routes.MapPageRoute("AdminRoles", "Admin/Roles", "~/Templates/Website/Admin/Roles/Roles.aspx");
            routes.MapPageRoute("AdminUserRoles", "Admin/UserRoles", "~/Templates/Website/Admin/UserRoles/UserRoles.aspx");
            routes.MapPageRoute("AdminArtists", "Admin/Artists", "~/Templates/Website/Admin/Artists/Artists.aspx");
            //Users
            routes.MapPageRoute("User", "User", "~/Templates/Website/User/User.aspx");
            routes.MapPageRoute("UserLogin", "Login", "~/Templates/Website/User/Login.aspx");
            routes.MapPageRoute("UserRegister", "Register", "~/Templates/Website/User/Register.aspx");

            //Events
            routes.MapPageRoute("Events", "Events", "~/Templates/Website/Events/Events.aspx");
            routes.MapPageRoute("EventsAdd", "Events/Add", "~/Templates/Website/Events/AddEvent.aspx");
            routes.MapPageRoute("EventsEdit", "Events/Edit", "~/Templates/Website/Events/EditEvent.aspx");

            //Venues
            routes.MapPageRoute("Venues", "Venues", "~/Templates/Website/Venues/Venues.aspx");
            routes.MapPageRoute("VenuesAdd", "Venues/Add", "~/Templates/Website/Venues/AddVenues.aspx");
            routes.MapPageRoute("VenuesEdit", "Venues/Edit", "~/Templates/Website/Venues/EditVenues.aspx");

            //Artist
            routes.MapPageRoute("Artists", "Artists", "~/Templates/Website/Artists/Artists.aspx");
            routes.MapPageRoute("ArtistsAdd", "Artists/Add", "~/Templates/Website/Artists/AddArtists.aspx");
            routes.MapPageRoute("ArtistsEdit", "Artists/Edit", "~/Templates/Website/Artists/EditArtists.aspx");
            //routes.MapPageRoute("Admin", "", "~/Templates/Website/F.aspx");



            //routes.MapPageRoute("Admin", "", "~/Templates/Website/Admin/.aspx");

        }

    }
}