
using DemoISPSessionCore.Models;
using ispsession.io.core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace DemoISPSessionCore
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
            services.Configure<SessionAppSettings>(Configuration.GetSection("ispsession.io"));
            services.Configure<CacheAppSettings>(Configuration.GetSection("ispcache.io"));

            services.AddISPSession();
              services.AddISPCache();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseISPSession();
            app.UseISPCache();
            //initialize application

            app.UseCookiePolicy();

            app.UseMvc();
#pragma warning disable 1998
            app.Run(async context =>
            {                
                if (!context.ApplicationCache().KeyExists("SomeCache"))
                {
                    context.ApplicationCache()["SomeCache"] = new SomeCacheClass() { SomeDate = DateTimeOffset.Now, SomeString = "Some fancy string" };
                }
            });
        }
    }
}
