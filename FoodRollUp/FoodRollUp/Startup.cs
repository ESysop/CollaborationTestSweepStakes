using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodRollUp.Startup))]
namespace FoodRollUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
