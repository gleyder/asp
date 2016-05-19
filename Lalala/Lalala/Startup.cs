using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lalala.Startup))]
namespace Lalala
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
