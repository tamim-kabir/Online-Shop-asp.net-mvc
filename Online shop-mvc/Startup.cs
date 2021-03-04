using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_shop_mvc.Startup))]
namespace Online_shop_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
