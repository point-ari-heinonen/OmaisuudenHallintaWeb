using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OmaisuudenHallintaWeb.Startup))]
namespace OmaisuudenHallintaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
