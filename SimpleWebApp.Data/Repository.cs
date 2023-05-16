using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleWebApp.Core.Interfaces;
using SimpleWebApp.Core.SharedKernel;

namespace SimpleWebApp.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppContext context;
        public Repository(AppContext context)
        {
            this.context = context;
        }

        public T Get(int id)
        {
            return context.Find<T>(id);
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public T Add(T entity)
        {
            context.Add<T>(entity);
            return entity;
        }

        public void Update(T entity)
        {
            context.Update<T>(entity);
        }

        public void Delete(int id)
        {
            context.Remove<T>(Get(id));
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
