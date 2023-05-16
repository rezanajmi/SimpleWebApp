using Microsoft.Extensions.DependencyInjection;
using SimpleWebApp.Application;
using SimpleWebApp.Core.Interfaces;
using SimpleWebApp.Data;

namespace SimpleWebApp.Web
{
    internal static class Startup
    {
        internal static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterDatabase(configuration.GetConnectionString("Sqlite"));

            services.RegisterDataServices();
            services.RegisterApplicationServices();

            services.AddControllersWithViews();
        }

        internal static void ConfigureApp(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/home/error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.MapDefaultControllerRoute();

            using (var scope = app.Services.CreateScope())
            {
                using (var dbInit = scope.ServiceProvider.GetRequiredService<IDatabaseInitializer>())
                {
                    dbInit.Migrate();
                    dbInit.SeedData();
                }
            }
        }
    }
}
