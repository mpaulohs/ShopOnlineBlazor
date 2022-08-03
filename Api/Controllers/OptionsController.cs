using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{

    [ApiController]
    [Route("/")]
    public class OptionsController : ControllerBase
    {
        [HttpOptions]
        public ContentResult Options()
        {
            var html = System.IO.File.ReadAllText(@"./web/options.html");
            return new ContentResult
            {
                Content = html,
                ContentType = "text/html"
            };
        }

        [HttpGet]
        public ContentResult Index()
        {
            try
            {
                var html = System.IO.File.ReadAllText(@"./web/options.html");
                return new ContentResult
                {
                    Content = html,
                    ContentType = "text/html"
                };
            }
            catch (System.Exception)
            {
                return new ContentResult
                {
                    Content = "<h1>RestApi documentation</h1>",
                    ContentType = "text/html"
                };
            }



        }
    }
}