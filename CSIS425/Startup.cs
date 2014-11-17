using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSIS425.Startup))]
namespace CSIS425
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app); //hey
        }
    }
}
