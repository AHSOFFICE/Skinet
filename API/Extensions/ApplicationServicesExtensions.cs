using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Errors;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection Services,
        IConfiguration config)
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
Services.AddEndpointsApiExplorer();
Services.AddSwaggerGen();
Services.AddDbContext<StoreContext>(opt=>
{
opt.UseSqlite(config.GetConnectionString("DefaultConnection"));

});

Services.AddScoped<IProductRepository,ProductRepository>();

Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
Services.Configure<ApiBehaviorOptions>(Options =>
{

Options.InvalidModelStateResponseFactory=actionContext => 
{

var errors= actionContext.ModelState
.Where(e=> e.Value.Errors.Count>0)
.SelectMany(x=>x.Value.Errors)
.Select(x=>x.ErrorMessage).ToArray();

var errorResponse= new ApiValidationErrorResponse
{
    Errors=errors
};
return new BadRequestObjectResult(errorResponse);
};

});

        return Services;



        } 
    }
}