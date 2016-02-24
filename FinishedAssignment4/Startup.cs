using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinishedAssignment4.Startup))]
namespace FinishedAssignment4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
