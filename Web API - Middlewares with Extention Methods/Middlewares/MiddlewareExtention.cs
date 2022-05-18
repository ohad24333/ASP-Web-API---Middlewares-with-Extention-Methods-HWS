using Microsoft.AspNetCore.Builder;

namespace Web_API___Middlewares_with_Extention_Methods
{
    public static class MiddlewareExtention
    {
        public static IApplicationBuilder UsePrintIdMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PrintIdMiddleware>();
        }

         public static IApplicationBuilder UsePrintClassIdMiddleware (this IApplicationBuilder builder)
        {

            return builder.UseMiddleware<PrintClassIdMiddleware>();
        }

        public static IApplicationBuilder UseClassNumber_5_Middleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ClassNumber_5_Middleware>();
        }
    }
}
