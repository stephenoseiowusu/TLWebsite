using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TLWebsite.Startup))]
namespace TLWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
