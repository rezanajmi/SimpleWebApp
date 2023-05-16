using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleWebApp.Core.Interfaces;

namespace SimpleWebApp.Data
{
    public static class DataServicesRegistration
    {
        public static void RegisterDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
        }

        public static void RegisterDataServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IDatabaseInitializer, DatabaseInitializer>();
        }
    }
}
