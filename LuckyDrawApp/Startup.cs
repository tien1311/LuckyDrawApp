
using JwtAuthenticationHelper.Extensions;
using JwtAuthenticationHelper.Types;
using LuckyDrawApp.Service;
using LuckyDrawApp.Service.Abstraction;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLog.Web;

namespace Manager_EV
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           // Access HttpContext
           var tokenOptions = new TokenOptions(
                Configuration["Token:Audience"],
                Configuration["Token:Issuer"],
                Configuration["Token:SigningKey"]);

            services.AddJwtAuthenticationWithProtectedCookie(
                  tokenOptions);
            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequiresAdmin",
                    policy =>
                    policy.RequireClaim("HasAdminRights"));
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddHttpContextAccessor();

            //services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
            services.AddSession();
            services.AddHttpClient("luckydraw-service", (service, client) =>
            {
                client.BaseAddress = new System.Uri(Configuration["LuckyDrawService:ApiHost"]);
                client.DefaultRequestHeaders.Add("x-functions-key", Configuration["LuckyDrawService:ApiKey"]);
            });
            services.AddScoped<ILuckyDrawService, LuckyDrawService>();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //add NLog to ASP.NET Core
            loggerFactory.AddNLog();

            //add NLog.Web
            app.AddNLogWeb();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               
            }
            else
            {
             
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
          
      

            app.Use(async (context, next) =>
            {
                await next.Invoke();

                //After going down the pipeline check if we 404'd. 
                if (context.Response.StatusCode == StatusCodes.Status404NotFound)
                {
                    await context.Response.WriteAsync("Woops! We 404'd");
                }
            });
            //Add our new middleware to the pipeline
            //app.UseMiddleware<RequestResponseLoggingMiddleware>();
   
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}









