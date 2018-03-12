using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bsi24tallerbilly.Startup))]
namespace bsi24tallerbilly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
