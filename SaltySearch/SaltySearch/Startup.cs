using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaltySearch.Startup))]
namespace SaltySearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
