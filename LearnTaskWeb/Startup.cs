using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnTaskWeb
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(c => { c.EnableEndpointRouting = false; });
            services.AddMvcCore(o => o.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseMvc(c =>
                 c.MapRoute(
                     name: "default",
                     template: "{controller}/{action}/{id?}",
                     defaults: new { controller = "Root", action = "Index" }
                 )
             );
            app.Map("/home", Home);
            app.Map("/weatherforecast", WeatherForecast);
        }

        private static void Home(IApplicationBuilder app)
        {
            app.UseMvc(c =>
                 c.MapRoute(
                     name: "home",
                     template: "{controller}/{action}/{id?}",
                     defaults: new { controller = "Home", action = "Page" }
                 )
             );
        }

        private static void WeatherForecast(IApplicationBuilder app)
        {
            app.UseMvc(c =>
                 c.MapRoute(
                     name: "weatherforecast",
                     template: "{controller}/{action}/{id?}",
                     defaults: new { controller = "WeatherForecast", action = "WeatherPage" }
                 )
             );

        }
    }
}