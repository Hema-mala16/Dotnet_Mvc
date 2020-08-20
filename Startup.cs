using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieCustomerMvcApp.Startup))]
namespace MovieCustomerMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
