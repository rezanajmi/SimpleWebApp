using SimpleWebApp.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApp.Application.Interfaces
{
    public interface IGenericService<T> where T : BaseEntity
    {
        public T Get(int id);
        public IList<T> GetAll();
        public T Add(T entity);
        public void Update(T entity);
        public void Delete(int id);
    }
}
