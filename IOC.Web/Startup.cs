using IOC.Web.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOC.Web
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
            //herhangý býr classýn ctorunda ISingletonDateService görülürse dateservice enjekte edilir
            //ve uygulamanýn heryerýnde ýlk olusturulan nesne ornegý kullanýlýr
            services.AddSingleton<ISingletonDateService,DateService>();
            //býr req esnasýnda 5 kez ctorda gecýyorsa ýlk yerde olusturulur ve kalanlarda da bu kullanýlýr
            services.AddScoped<IScopedDateService,DateService>();
            //herhangý býr ctorda ITransientDateService gorulurse her gorulen yerde býr nesne ornegý olustur
            //5 kez gecýyorsa 5 nesne olusturulur
            services.AddTransient<ITransientDateService,DateService>();    


            services.AddControllersWithViews();
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
