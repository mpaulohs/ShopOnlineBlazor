using Microsoft.AspNetCore.Mvc;
using ShopOnline.Library;

namespace Client.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentSaleController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<DocumentSaleController> _logger;

        public DocumentSaleController(ILogger<DocumentSaleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<DocumentSale> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new DocumentSale
            {
                CreatedAt = DateTime.Now.AddDays(index),
                UpdatedAt = DateTime.Now.AddDays(index),
                ContractAmount = Random.Shared.Next(-20, 55),
               // DocumentAmount = DocumentAmount[Random.Shared.Next(DocumentAmount.Length)]
            })
            .ToArray();
        }
    }
}