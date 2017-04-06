using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HWProductionBlog.Startup))]
namespace HWProductionBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
