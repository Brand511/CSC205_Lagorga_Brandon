using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSC205_Lagorga_Brandon.Startup))]
namespace CSC205_Lagorga_Brandon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
