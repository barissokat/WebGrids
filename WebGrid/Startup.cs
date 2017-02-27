using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebGrid.Startup))]
namespace WebGrid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
