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
            var html = System.IO.File.ReadAllText(@"./api/web/options.html");
            return new ContentResult
            {
                Content = html,
                ContentType = "text/html"
            };
        }

        [HttpGet]
        public ContentResult Index()
        {
            var html = System.IO.File.ReadAllText(@"./api/web/options.html");
            return new ContentResult
            {
                Content = html,
                ContentType = "text/html"
            };
        }
    }
}