using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DI_example.Startup))]
namespace DI_example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
