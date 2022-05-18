using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Web_API___Middlewares_with_Extention_Methods
{
    public class PrintIdMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            string id = (context.Request.Path.Value).Split('/')[2];
            await context.Response.WriteAsync($"id = {id}\n");
        }
    }
}
