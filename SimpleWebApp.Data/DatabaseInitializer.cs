using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpleWebApp.Core.Entities;
using SimpleWebApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApp.Data
{
    internal class DatabaseInitializer : IDatabaseInitializer
    {
        private readonly AppContext context;
        public DatabaseInitializer(AppContext context)
        {
            this.context = context;
        }

        public void Migrate()
        {
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
        }

        public void SeedData()
        {
            if (context.Users.Any() == false)
            {
                var user = new User()
                {
                    Username = "rn",
                    Name = "Reza",
                    Family = "Najmi",
                    Password = "1234",
                };
                context.Users.Add(user);
                context.SaveChanges();

                context.Posts.Add(new Post()
                {
                    Title = "First Post",
                    Content = "This is first post in this web application!",
                    UserId = user.Id
                });
                context.SaveChanges();
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
