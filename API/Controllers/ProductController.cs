
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductController(StoreContext context)
        {
            _context = context;
            
        }




        [HttpGet]
        public  async Task <ActionResult<List<Product>>> GetProducts()
        {
        var product=await _context.product.ToListAsync();

            return product;
        }


 [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {

            return await _context.product.FindAsync(id);
        }


    }
}