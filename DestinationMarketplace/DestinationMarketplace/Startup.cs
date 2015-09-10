using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DestinationMarketplace.Startup))]
namespace DestinationMarketplace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
