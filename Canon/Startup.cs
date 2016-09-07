using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Canon.Startup))]
namespace Canon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
