using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BFKH.Startup))]
namespace BFKH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
