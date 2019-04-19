using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITShop.Startup))]
namespace ITShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
