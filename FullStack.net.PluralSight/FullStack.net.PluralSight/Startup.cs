using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullStack.net.PluralSight.Startup))]
namespace FullStack.net.PluralSight
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
