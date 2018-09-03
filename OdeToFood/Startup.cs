using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OdeToFood.Services;

namespace OdeToFood
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddScoped<IResturantData, InMemoryResturantData>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IGreeter greeter, ILogger<Startup> looger)
        {
            {
                //app.Use(next =>
                //{
                //    return async context =>
                //    {
                //        looger.LogInformation("Incomming Request");
                //        if (context.Request.Path.StartsWithSegments("/mym"))
                //        {
                //            await context.Response.WriteAsync("Hit Custom Middleware");
                //            looger.LogInformation("Handled Request");

                //        }
                //        else
                //        {
                //            await next(context);
                //            looger.LogInformation("outgoing Response");

                //        }
                //    };
                //});
                //app.UseWelcomePage(new WelcomePageOptions
                //{
                //    Path="/wp"
                //});
              //  app.UseFileServer(); //use defualtfile and staticfiles
                
            }
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error.html");
            }
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.Run(async (context) =>
            {
                
                var greeting = greeter.GetMessageOfTheDay();
                await context.Response.WriteAsync($"Greeting : {greeting}");
            });
        }
    }
}
