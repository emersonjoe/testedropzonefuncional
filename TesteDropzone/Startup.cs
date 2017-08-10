using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteDropzone.Startup))]
namespace TesteDropzone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
