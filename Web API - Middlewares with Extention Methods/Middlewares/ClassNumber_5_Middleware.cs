using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Web_API___Middlewares_with_Extention_Methods
{
    public class ClassNumber_5_Middleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("This is class 5 !!!!!!!!");
        }
    }
}
