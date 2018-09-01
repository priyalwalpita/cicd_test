using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CICdTest.BL;
using CICdTest.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace CICdTest
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IStudentBl, StudentBl>();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v2", new Info { Title = "CI/CD Test App", Version = "v2" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v2/swagger.json", "CI/CD Test App");
            });

            app.Run(async (context) => { await context.Response.WriteAsync("This is a CI/CD Test App"); });
        }
    }
}