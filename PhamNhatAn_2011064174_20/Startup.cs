using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamNhatAn_2011064174_20.Startup))]
namespace PhamNhatAn_2011064174_20
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
