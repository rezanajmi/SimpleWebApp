using Microsoft.Extensions.DependencyInjection;
using SimpleWebApp.Application.Interfaces;
using SimpleWebApp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApp.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPostService, PostService>();
        }
    }
}
