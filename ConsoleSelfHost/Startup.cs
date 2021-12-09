using System.Net.Http.Formatting;
using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ConsoleSelfHost.Startup))]

namespace ConsoleSelfHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            app.UseWebApi(config);
        }
    }

    public class ClassTest
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "FUNCIONANDO OK!";
    }
}
