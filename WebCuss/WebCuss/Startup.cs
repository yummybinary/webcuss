using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCuss.Startup))]
namespace WebCuss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
