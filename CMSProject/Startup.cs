using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMSProject.Startup))]
namespace CMSProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
