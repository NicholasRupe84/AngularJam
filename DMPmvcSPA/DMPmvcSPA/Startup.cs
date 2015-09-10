using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMPmvcSPA.Startup))]
namespace DMPmvcSPA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
