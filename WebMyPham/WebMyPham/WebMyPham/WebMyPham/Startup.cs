using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMyPham.Startup))]
namespace WebMyPham
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
