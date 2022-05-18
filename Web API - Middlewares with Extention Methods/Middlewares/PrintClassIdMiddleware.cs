using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API___Middlewares_with_Extention_Methods
{
    public class PrintClassIdMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {  
                string classId = (context.Request.Path.Value).Split('/')[1];
                await context.Response.WriteAsync($"class Id = {classId}\n");
                await next(context);        
        }
    }
}
