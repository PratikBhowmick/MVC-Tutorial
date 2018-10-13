using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Studentdetails.Startup))]
namespace Studentdetails
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
