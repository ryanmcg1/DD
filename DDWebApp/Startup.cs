using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DDWebApp.Startup))]
namespace DDWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
