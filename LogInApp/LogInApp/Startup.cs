using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LogInApp.Startup))]
namespace LogInApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
