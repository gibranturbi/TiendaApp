using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TiendaApp.Startup))]
namespace TiendaApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
