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

/*
         public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(c => { c.EnableEndpointRouting = false; });
            services.AddMvcCore(o => o.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();


            app.UseMvc(c =>
                 c.MapRoute(
                     name: "default",
                     //������ ���� �� ������ �������� URL
                     //������ ������ (���� ������ ������)"www.za.piv.com/{controller}/{action}/{id?}",
                     template: "{controller}/{action}/{id?}",
                     defaults: new { controller = "Root", action = "Person" }
                 )
             );

        }
 */

namespace LearnTaskWeb
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IConfiguration Configuration { get; }

        //// This method gets called by the runtime. Use this method to add services to the container.
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddRazorPages();
        //}

        //// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //{
        //    if (env.IsDevelopment())
        //    {
        //        app.UseDeveloperExceptionPage();
        //    }
        //    else
        //    {
        //        app.UseExceptionHandler("/Error");
        //        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        //        app.UseHsts();
        //    }

        //    app.UseHttpsRedirection();
        //    app.UseStaticFiles();

        //    app.UseRouting();

        //    app.UseAuthorization();
        //    app.Map("/home", Home);
        //    app.Map("/about", About);
        //    app.Map("/listofgays", ListOfGays);

        //    app.UseEndpoints(endpoints =>
        //    {
        //        endpoints.MapRazorPages();
        //    });
        //}

        //private static void Home(IApplicationBuilder app)
        //{
        //    app.Run(async context =>
        //    {
        //        await context.Response.WriteAsync("Home");
        //    });
        //}

        //private static void About(IApplicationBuilder app)
        //{
        //    app.Run(async context =>
        //    {
        //        await context.Response.WriteAsync("About");
        //    });
        //}

        //private static void ListOfGays(IApplicationBuilder app)
        //{
        //    app.Run(async context =>
        //    {
        //        await context.Response.WriteAsync("List of evil people who offend me");
        //    });
        //}

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(c => { c.EnableEndpointRouting = false; });
            services.AddMvcCore(o => o.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
        }
    }
}
