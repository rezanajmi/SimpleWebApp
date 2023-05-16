using SimpleWebApp.Application.Interfaces;
using SimpleWebApp.Core.Entities;
using SimpleWebApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApp.Application.Services
{
    internal class UserService : GenericService<User>, IUserService
    {
        public UserService(IRepository<User> repository) : base(repository)
        {
        }
    }
}
