using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mediateka.Startup))]
namespace Mediateka
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
