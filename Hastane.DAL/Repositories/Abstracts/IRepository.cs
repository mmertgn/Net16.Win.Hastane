using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL.Repositories.Abstracts
{
    public interface IRepository<T>
        where T : class, new()
    {
        void Add(T entity);
        void Delete(int Id);
        void Update(T entity);
        int Save();
        List<T> GetList(Expression<Func<T, bool>> predicate = null);
        T FindById(int Id);
    }
}
