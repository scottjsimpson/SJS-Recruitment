using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScottWebApp.Startup))]
namespace ScottWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
