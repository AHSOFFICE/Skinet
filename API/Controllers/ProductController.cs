
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;
using Core.Specifications;
using API.Dtos;
using AutoMapper;
using API.Errors;

namespace API.Controllers
{

    public class ProductController : BaseApiController
    {
       
        

        private readonly IGenericRepository<Product> _productRepo;
        private readonly IGenericRepository<ProductBrand> _productBrandRepo;
        private readonly IGenericRepository<ProductType> _productTypeRepo;
        
        

        private readonly IMapper _mapper;

        public ProductController(IGenericRepository<Product> productRepo,
        IGenericRepository<ProductBrand> productBrandRepo,
        IGenericRepository<ProductType> productTypeRepo, IMapper mapper)
        {
           
            _mapper = mapper;          
            _productRepo = productRepo;
            _productBrandRepo = productBrandRepo;
            _productTypeRepo = productTypeRepo;
            
            
        }




        [HttpGet]
        public  async Task <ActionResult<IReadOnlyList<ProductToReturnDto>>> GetProducts()
        {
        var spec=new ProductWithTypesAndBrandsSpecification();
        var product =await _productRepo.ListAsync(spec);

            return Ok(_mapper
            .Map<IReadOnlyList<Product>,IReadOnlyList<ProductToReturnDto>>(product));
        }


 [HttpGet("{id}")]
 [ProducesResponseType(StatusCodes.Status200OK)]
 [ProducesResponseType(typeof(ApiResponse),StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductToReturnDto>> GetProduct(int id)
        {

            var spec=new ProductWithTypesAndBrandsSpecification(id);
            var product= await _productRepo.GetEntityWithSpec(spec);

            if(product ==null) return NotFound(new ApiResponse(404));
            return _mapper.Map<Product,ProductToReturnDto>(product);
        }

[HttpGet("brands")]
public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
{

return Ok(await _productBrandRepo.ListAllAsync());

}

[HttpGet("types")]
public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
{

return Ok(await _productTypeRepo.ListAllAsync());

}




}

}
