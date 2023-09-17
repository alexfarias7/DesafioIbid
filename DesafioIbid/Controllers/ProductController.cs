using Microsoft.AspNetCore.Mvc;

namespace DesafioIbid.Controllers
{
    [Route("/api/products")]
    public class ProductController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
