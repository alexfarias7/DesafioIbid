using DesafioIbid.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioIbid.Controllers
{
    [Route("/api/products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }


        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductModel product)
        {
            if (product.Name.Length > 50)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] ProductModel product)
        {
            if (product.Description.Length < 3)
            {
                return BadRequest();
            }
            return NoContent();
        }


        [HttpDelete("id")]
        public IActionResult DeleteProduct(int id, [FromBody] ProductModel product)
        {
            if (product.Id.Equals(id))
            {
                return BadRequest();
            }
            return NoContent();
        }
    }
}
