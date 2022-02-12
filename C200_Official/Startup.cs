using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using C200_Official.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Hosting;
using Rotativa.AspNetCore;
using System.Text;

namespace C200_Official //change this accordingly
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        	{

                    Configuration = configuration;
            		RotativaConfiguration.Setup(env);

        }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false)
                    .AddNewtonsoftJson();
            services.AddDbContext<AppDbContext>(
      options =>
         options
            .UseSqlServer(
                 Configuration.GetConnectionString("DefaultConnection")));
            services
   .AddAuthentication("HealthyScheme") //Healthy tick scheme
   .AddCookie("HealthyScheme",
       options =>
       {
           options.LoginPath = "/Account/Login/";
           options.AccessDeniedPath = "/Account/Forbidden/";
       });

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseAuthentication(); // to activate the authentication
            app.UseMvc(
               routes =>
               {
                   routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
               });

        }
    }
}
