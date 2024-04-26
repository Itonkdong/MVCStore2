using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCStore2.Startup))]
namespace MVCStore2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
