using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DealDoube.Web.Startup))]
namespace DealDoube.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
