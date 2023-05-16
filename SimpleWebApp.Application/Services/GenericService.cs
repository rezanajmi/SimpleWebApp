using SimpleWebApp.Core.SharedKernel;
using SimpleWebApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleWebApp.Application.Interfaces;

namespace SimpleWebApp.Application.Services
{
    internal abstract class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        protected readonly IRepository<T> repository;
        public GenericService(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public T Get(int id)
        {
            return repository.Get(id);
        }

        public IList<T> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public T Add(T entity)
        {
            repository.Add(entity);
            repository.Save();
            return entity;
        }

        public void Update(T entity)
        {
            repository.Update(entity);
            repository.Save();
        }

        public void Delete(int id)
        {
            repository.Delete(id);
            repository.Save();
        }
    }
}
