using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TrainCertificates.Domain.Abstract;

namespace TrainCertificates.Domain.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> _entities;

        public Repository(DbContext context)
        {
            _entities = context.Set<T>();
        }

        public T Get(int id)
        {
            return _entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _entities.AddRange(entities);
        }

        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _entities.RemoveRange(entities);
        }
    }
}
