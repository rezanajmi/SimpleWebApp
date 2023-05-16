using SimpleWebApp.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApp.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        public T Get(int id);
        public IQueryable<T> GetAll();
        public T Add(T entity);
        public void Update(T entity);
        public void Delete(int id);
        public void Save();
    }
}
