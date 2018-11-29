using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Github_Workshop.Startup))]
namespace Github_Workshop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
