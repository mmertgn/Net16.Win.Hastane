using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.DAL.Repositories.Concretes
{
    public class IlRepository : EFRepositoryBase<iller,HastaneEntities> ,IILRepository
    {
        public IlRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }

        public List<iller> ilGetir(string ilAdi)
        {
            return _dbSet.Where(x =>x.sehir==ilAdi).ToList();
        }
    }
}
