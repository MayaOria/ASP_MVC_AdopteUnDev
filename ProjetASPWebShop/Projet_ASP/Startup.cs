using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Projet_ASP.Handlers;
using Projet_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLLEntities = Projet_BLL.Entities;
using BLLServices = Projet_BLL.Services;
using DALEntities = Projet_DAL.Entities;
using DALServices = Projet_DAL.Services;

namespace Projet_ASP
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

            services.AddHttpContextAccessor();

            services.AddScoped<SessionManager>();

            #region Cookies de consentement & de session

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = "AdopteUnDev.Session";
                options.Cookie.HttpOnly = true;
                options.IdleTimeout = TimeSpan.FromMinutes(20);
                options.Cookie.IsEssential = true;
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.Secure = CookieSecurePolicy.Always;

            });
            #endregion

            #region Injection de dépendance
            services.AddScoped<IDeveloperRepository<BLLEntities.Developer, int>, BLLServices.DeveloperService>();
            services.AddScoped<IDeveloperRepository<DALEntities.Developer, int>, DALServices.DeveloperService>();
            services.AddScoped<IItLangRepository<BLLEntities.ItLang, int>, BLLServices.ItLangService>();
            services.AddScoped<IItLangRepository<DALEntities.ItLang, int>, DALServices.ItLangService>();
            services.AddScoped<IDevLangRepository<BLLEntities.DevLang, int>, BLLServices.DevLangService>();
            services.AddScoped<IDevLangRepository<DALEntities.DevLang, int>, DALServices.DevLangService>();
            services.AddScoped<ICategoriesRepository<DALEntities.Categories, int>, DALServices.CategoriesService>();
            services.AddScoped<ICategoriesRepository<BLLEntities.Categories, int>, BLLServices.CategoriesService>();
            services.AddScoped<IClientRepository<BLLEntities.Client, int>, BLLServices.ClientService>();
            services.AddScoped<IClientRepository<DALEntities.Client, int>, DALServices.ClientService>();
            #endregion
           

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
            }
            app.UseSession();
            app.UseCookiePolicy();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(
                //    name: "login",
                //    pattern: "",
                //    defaults: new { controller = "Home", action = "Login" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
