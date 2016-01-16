using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YourProtocolWeb.Startup))]
namespace YourProtocolWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
