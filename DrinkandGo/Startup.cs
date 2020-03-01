using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using DrinkandGo.Data.Interfaces;
using DrinkandGo.Data.Mocks;

namespace DrinkandGo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //is to configure Dependings
            //services.AddTransient<interface,implementation>
            services.AddTransient<IDrinkRepository, MockDrinkRepository>();
            services.AddTransient<ICategoryRepository, MockCategoryRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            //used to render the Exception during Development Mode
            app.UseDeveloperExceptionPage();
            //Used to show error pages for HTTP status Codes
            app.UseStatusCodePages();
            // we can use static files like custom css...
            app.UseStaticFiles();
            //Defines default route and supports attribute loading
            app.UseMvcWithDefaultRoute();

            /*
             app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
             */

        }
    }
}
