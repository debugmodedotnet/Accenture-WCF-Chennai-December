using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataContractDemo.MVCClient.Startup))]
namespace DataContractDemo.MVCClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
