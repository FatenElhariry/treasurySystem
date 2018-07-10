using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(treasury.Startup))]
namespace treasury
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
