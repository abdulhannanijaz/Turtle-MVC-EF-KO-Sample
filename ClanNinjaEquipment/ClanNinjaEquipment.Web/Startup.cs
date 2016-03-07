using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClanNinjaEquipment.Web.Startup))]
namespace ClanNinjaEquipment.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
