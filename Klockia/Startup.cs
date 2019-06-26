using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Klockia.Startup))]
namespace Klockia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
