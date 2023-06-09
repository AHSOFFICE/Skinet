using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T :BaseEntity
    {
        private readonly StoreContext context;

    public GenericRepository(StoreContext context)
    {
            this.context = context;
    
    }

        public async Task<T> GetbyIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }
      

        public async Task<T> GetEntityWithSpec(ISpecification<T> spec)
        {
           return await ApplySpecfication(spec).FirstOrDefaultAsync();
        }

      

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecfication(spec).ToListAsync();
        }
   

 public async Task<int> CountAsync(ISpecification<T> spec)  //Number of records
        {
           return await ApplySpecfication(spec).CountAsync();
        }

   private IQueryable<T> ApplySpecfication(ISpecification<T> spec)
   {
    return SpecificationEvaluator<T>.GetQuery(context.Set<T>().AsQueryable(),spec);
   }

       
    }
}