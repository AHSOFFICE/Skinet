using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithFiltersForCountSpecifications :BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecifications(ProductSpecParams productParams)
        :base (x=>
        (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains
        (productParams.Search)) && 
        (!productParams.brandId.HasValue  || x.ProductBrandId==productParams.brandId) && 
        (!productParams.TypeId.HasValue || x.ProductTypeId==productParams.TypeId)
        
        )
        {







        }
    }
}