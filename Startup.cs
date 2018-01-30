using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhonebookMVC.Startup))]
namespace PhonebookMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
