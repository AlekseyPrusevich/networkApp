using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using networkApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace networkApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IUserValidator<User>, CustomUserValidator>();

            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>();

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();    // подключение аутентификации
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        /*
        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .AddXmlFile("Data/question.xml");
            AppConfiguration = builder.Build();
        }
        public IConfiguration AppConfiguration { get; set; }

        public void Configure(IApplicationBuilder app)
        {
            var num = AppConfiguration["numQuestion:num"];
            var textQuestion = AppConfiguration["numQuestion:textQuestion"];
            var numAnswer = AppConfiguration["numQuestion:answers:numAnswer"];
            var answer = AppConfiguration["numQuestion:answers:answer"];
            var trueAnswer = AppConfiguration["numQuestion:trueAnswer"];
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"<p>{num}</br>{textQuestion}</br>{numAnswer}</br>{answer}</br>{trueAnswer}</br></p>");
            });
        }
        */
    }
}
