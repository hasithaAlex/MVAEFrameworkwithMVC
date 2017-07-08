using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Application04.Startup))]
namespace Application04
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
