using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWebAppGit.Startup))]
namespace MvcWebAppGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
