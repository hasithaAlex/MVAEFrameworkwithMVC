using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Application05.Startup))]
namespace Application05
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
