using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webMVCSaga.Startup))]
namespace webMVCSaga
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
