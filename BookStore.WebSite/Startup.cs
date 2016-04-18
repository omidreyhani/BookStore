using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BookStore.WebSite.Startup))]

namespace BookStore.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
