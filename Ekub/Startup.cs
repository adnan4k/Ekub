using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ekub.Startup))]
namespace Ekub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
