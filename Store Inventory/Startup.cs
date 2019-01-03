using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Store_Inventory.Startup))]
namespace Store_Inventory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
