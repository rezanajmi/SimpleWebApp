using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApp.Core.Interfaces
{
    public interface IDatabaseInitializer : IDisposable
    {
        public void Migrate();
        public void SeedData();
    }
}
