using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_4thJune.Startup))]
namespace _4thJune
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
