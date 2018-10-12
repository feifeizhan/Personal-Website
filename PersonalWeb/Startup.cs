using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalWeb.Startup))]
namespace PersonalWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
