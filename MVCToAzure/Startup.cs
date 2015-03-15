using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCToAzure.Startup))]
namespace MVCToAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
