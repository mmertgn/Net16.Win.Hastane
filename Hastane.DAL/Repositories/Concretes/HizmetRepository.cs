using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.DAL.Repositories.Concretes
{
    public class HizmetRepository : EFRepositoryBase<Hizmetler, HastaneEntities>, IHizmetRepository
    {
        public HizmetRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }

        public int GetHizmetCount()
        {
            return _dbSet.Count();
        }
    }
}
