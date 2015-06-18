using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCServiceWithAngular.Startup))]
namespace MVCServiceWithAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
