using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIGBL.Web.Startup))]
namespace SIGBL.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
