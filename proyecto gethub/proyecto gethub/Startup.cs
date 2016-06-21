using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyecto_gethub.Startup))]
namespace proyecto_gethub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
