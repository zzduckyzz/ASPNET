using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAuthentication.Startup))]
namespace TestAuthentication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
