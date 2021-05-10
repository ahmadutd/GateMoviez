using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using GateMoviez.Application;
//using GateMoviez.Application.Interfaces;
using GateMoviez.Data;
using GateMoviez.Domain;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DataMovies.Web
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
            services.AddControllersWithViews();


            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequireNonAlphanumeric = false;                

            }
            ).AddEntityFrameworkStores<GateMoviezDbContext>();


            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme
                ).AddCookie(option => 
                option.LoginPath = "/Account/Login"
                );


            services.AddDbContext<GateMoviezDbContext>(
                options => options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection"))
            );


            //services.AddScoped<VideoService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=actor}/{action=index}/{id?}");
            });
        }
    }
}
