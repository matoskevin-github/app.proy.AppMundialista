using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppMundialista.Startup))]
namespace AppMundialista
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
