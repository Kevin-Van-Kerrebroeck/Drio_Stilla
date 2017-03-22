using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_Stilla.Startup))]
namespace Project_Stilla
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
