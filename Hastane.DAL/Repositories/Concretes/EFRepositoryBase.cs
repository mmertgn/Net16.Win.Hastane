using Hastane.DAL.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL.Repositories.Concretes
{
    public class EFRepositoryBase<T,TContext> : IRepository<T>
        where T : class, new()
        where TContext:DbContext
    {
        protected DbContext _dbContext; //database bağlanmamızı sağlar
        protected IDbSet<T> _dbSet; //tablolara bağlanmamızı sağlar

        public EFRepositoryBase(TContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }   
        public void Add(T entity)
        {
            using (var context = _dbContext)
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Added;
            }
        }

        public void Delete(int Id)
        {
            using (var context = _dbContext)
            {
                var entity = _dbSet.Find(Id);
                var entry = context.Entry(entity);
                entry.State = EntityState.Deleted;
            }
        }

        public T FindById(int Id)
        {
            return _dbSet.Find(Id);
        }

        public List<T> GetList(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return _dbSet.ToList();
            }

            return _dbSet.Where(predicate).ToList();
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            using (var context = _dbContext)
            {
                var entry = _dbContext.Entry(entity);
                entry.State = EntityState.Modified;
            }
        }
    }
}
