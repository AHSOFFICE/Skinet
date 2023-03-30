using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using API.Errors;

namespace API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ILogger<ExceptionMiddleware> _Logger { get; }
        private readonly IHostEnvironment _env;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger,
        IHostEnvironment env)
        {
           _env = env;
            _next=next;
            _Logger=logger;
          }


public async Task InvokeAsync(HttpContext context)
{

try{
await _next(context);


}catch(Exception ex)
{
_Logger.LogError(ex,ex.Message);

context.Response.ContentType="application/json";
context.Response.StatusCode=(int)HttpStatusCode.InternalServerError;

var Response=_env.IsDevelopment()
? new ApiException((int)HttpStatusCode.InternalServerError,ex.Message,ex.StackTrace.ToString())
: new ApiException ((int)HttpStatusCode.InternalServerError);


var option= new JsonSerializerOptions{PropertyNamingPolicy = JsonNamingPolicy.CamelCase};

var json= JsonSerializer.Serialize(Response,option);

await context.Response.WriteAsync(json);

}



}


}



}
