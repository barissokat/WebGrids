using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebGrids.Startup))]
namespace WebGrids
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
