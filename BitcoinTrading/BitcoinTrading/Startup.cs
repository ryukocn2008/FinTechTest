using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BitcoinTrading.Startup))]
namespace BitcoinTrading
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
