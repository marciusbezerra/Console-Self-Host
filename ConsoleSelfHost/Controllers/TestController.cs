using System.Web.Http;

namespace ConsoleSelfHost.Controllers
{
    public class TestController: ApiController
    {
        [HttpGet]
        public string Ok()
        {
            return "Ok";
        }

        [HttpGet]
        public ClassTest Test()
        {
            return new ClassTest();
        }
    }
}
