using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        public StoreContext _context { get; }
public ProductRepository(StoreContext _context)
{
            this._context = _context;
    
}

        public async Task<IReadOnlyList<Product>> GetProductAsync()
        {
            return await _context.product
            .Include(p=>p.ProductType)
            .Include(p=>p.ProductBrand)
            .ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.product
            .Include(p=>p.ProductType)
            .Include(p=>p.ProductBrand)
            .FirstOrDefaultAsync(p=>p.id==id);
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandAsync()
        {
           return await _context.ProductBrands.ToListAsync();
        }

        public async Task<IReadOnlyList<ProductType>> GetProductTypeAsync()
        {
           return await _context.ProductTypes.ToListAsync();
        }
    }
}