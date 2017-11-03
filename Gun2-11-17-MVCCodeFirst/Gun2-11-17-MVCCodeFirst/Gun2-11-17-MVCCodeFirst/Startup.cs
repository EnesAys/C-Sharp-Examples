using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gun2_11_17_MVCCodeFirst.Startup))]
namespace Gun2_11_17_MVCCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
