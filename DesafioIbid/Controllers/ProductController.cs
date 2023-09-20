using DesafioIbid.Models;
using DesafioIbid.Repositories.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioIbid.Controllers
{
    [Route("/api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;

        [HttpGet]
        public async Task<ActionResult<List<ProductModel>>> GetAll()
        {
            List<ProductModel> products = await _product.GetAll();
            return Ok(products);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ProductModel>> GetById(int id)
        {

            ProductModel product = await _product.GetById(id);
            return Ok(product);
        }

        [HttpGet("name")]
        public async Task<ActionResult<ProductModel>> GetByName(string name)
        {
            ProductModel product = await _product.GetByName(name);
            return Ok(product);
        }


        [HttpPost]
        public async Task<ActionResult<ProductModel>>  CreateProduct([FromBody] ProductModel productModel)
        {
            if (productModel.Name.Length > 50)
            {
                return BadRequest();
            }
            ProductModel product = await _product.CreateProduct(productModel);

            return Ok(product); ;
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<ProductModel>> UpdateProduct([FromBody] ProductModel productModel, int id)
        {
 
            productModel.Id = id;
            ProductModel product= await _product.UpdateProduct(productModel, id);

            return Ok(product);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductModel>> Delete(int id )
        {
            bool deleted = await _product.DeleteProduct(id);
            return Ok(deleted);
        }
    }
}
