using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eComStore.Startup))]
namespace eComStore
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
