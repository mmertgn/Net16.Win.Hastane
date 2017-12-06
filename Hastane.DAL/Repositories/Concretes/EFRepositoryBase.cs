using Hastane.DAL.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL.Repositories.Concretes
{
    public class EFRepositoryBase<T, TContext> : IRepository<T>
        where T : class, new()
        where TContext : DbContext
    {
        protected DbContext _dbContext; //database bağlanmamızı sağlar
        protected IDbSet<T> _dbSet; //tablolara bağlanmamızı sağlar
        protected bool _disposed = false;

        public EFRepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var entity = _dbSet.Find(Id);
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }
        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_disposed == false)
                {
                    Dispose();
                    _disposed = true;
                }
            }
        }

        public void Dispose()
        {
            //database bağlantısını kesip kaynakların ram e geri teslimini sağlar.
            _dbContext.Dispose();
            //Garbage Collector bu sınıfı ramden kaldırır.
            GC.SuppressFinalize(this);
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

        public void Update(T entity)
        {
            var entry = _dbContext.Entry(entity);
            entry.State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
