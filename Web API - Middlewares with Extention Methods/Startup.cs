using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API___Middlewares_with_Extention_Methods
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Web_API___Middlewares_with_Extention_Methods", Version = "v1" });
            });
            services.AddTransient<PrintClassIdMiddleware>();
            services.AddTransient<PrintIdMiddleware>();
            services.AddTransient<ClassNumber_5_Middleware>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           

            app.Map("/students", HandleStudentsRoute);
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web_API___Middlewares_with_Extention_Methods v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void HandleStudentsRoute(IApplicationBuilder app)
        {
            app.MapWhen((context) => context.Request.Path.Value.Split('/')[1] == "5",
                HandleClass_5_Route);
            
            app.UsePrintClassIdMiddleware();
            app.UsePrintIdMiddleware();
        }

        private void HandleClass_5_Route(IApplicationBuilder app)
        {
            app.UseClassNumber_5_Middleware();
        }
      
    }
}
