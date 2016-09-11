using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVCWebApplication.Startup))]
namespace TestMVCWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
