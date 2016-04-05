using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Djur.Startup))]
namespace MVC_Djur
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
