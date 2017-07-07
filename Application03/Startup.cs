using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Application03.Startup))]
namespace Application03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
