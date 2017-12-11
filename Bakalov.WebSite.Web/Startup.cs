using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bakalov.WebSite.Web.Startup))]
namespace Bakalov.WebSite.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
