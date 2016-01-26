using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecondCI.Startup))]
namespace SecondCI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
