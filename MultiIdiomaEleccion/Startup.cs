using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultiIdiomaEleccion.Startup))]
namespace MultiIdiomaEleccion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
