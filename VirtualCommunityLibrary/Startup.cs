using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VirtualCommunityLibrary.Startup))]
namespace VirtualCommunityLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
