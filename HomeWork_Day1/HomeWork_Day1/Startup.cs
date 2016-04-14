using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeWork_Day1.Startup))]
namespace HomeWork_Day1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
