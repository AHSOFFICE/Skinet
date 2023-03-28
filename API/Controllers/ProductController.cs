
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
       
        public IProductRepository Repo { get; }

        public ProductController(IProductRepository repo)
        {
            this.Repo = repo;
            
            
        }




        [HttpGet]
        public  async Task <ActionResult<List<Product>>> GetProducts()
        {
        
        var product =await Repo.GetProductAsync();

            return Ok(product);
        }


 [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {

            return await Repo.GetProductByIdAsync(id);
        }

[HttpGet("brands")]
public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
{

return Ok(await Repo.GetProductBrandAsync());

}

[HttpGet("types")]
public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
{

return Ok(await Repo.GetProductTypeAsync());

}




}

}
