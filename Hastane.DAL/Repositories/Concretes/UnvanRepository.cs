using Hastane.DAL.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Hastane.DAL.DataModel;

namespace Hastane.DAL.Repositories.Concretes
{
    public class UnvanRepository : EFRepositoryBase<Unvanlar, HastaneEntities>, IUnvanRepository
    {
        public UnvanRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public int GetUnvanCount()
        {
            return _dbSet.Count();
        }

        public List<Unvanlar> UnvanGetir(string PersonelUnvan)
        {
            return _dbSet.Where(x => x.PersonelUnvan == PersonelUnvan).ToList();
        }
    }
}
