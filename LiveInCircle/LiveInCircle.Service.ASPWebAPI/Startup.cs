using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiveInCircle.BLL.Concrete.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LiveInCircle.Service.ASPWebAPI
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScopeBLL();
            services.AddCors(options => options.AddPolicy("MyPolicy", builder =>
             {
                 builder.AllowAnyHeader();
                 builder.AllowAnyMethod();
                 builder.AllowAnyOrigin();
             }));
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("MyPolicy");
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
