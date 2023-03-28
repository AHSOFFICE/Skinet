
using System.Text.Json;
using Core.Entities;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {

if(!context.ProductBrands.Any())
{

var brandsdata=File.ReadAllText("../Infrastructure/Data/SeedData/brands.json");

var brands= JsonSerializer.Deserialize<List<ProductBrand>>(brandsdata);
context.ProductBrands.AddRange(brands);
}



if(!context.ProductTypes.Any())
{

var Typedata=File.ReadAllText("../Infrastructure/Data/SeedData/types.json");

var types= JsonSerializer.Deserialize<List<ProductType>>(Typedata);
context.ProductTypes.AddRange(types);
}




if(!context.product.Any())
{

var productdata=File.ReadAllText("../Infrastructure/Data/SeedData/products.json");

var product= JsonSerializer.Deserialize<List<Product>>(productdata);
context.product.AddRange(product);
}

if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();

    }
  }
}