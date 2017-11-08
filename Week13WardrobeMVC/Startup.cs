using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week13WardrobeMVC.Startup))]
namespace Week13WardrobeMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
