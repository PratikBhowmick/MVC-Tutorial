using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCClientValidation.Startup))]
namespace MVCClientValidation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
