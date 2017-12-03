using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.DAL.Repositories.Concretes
{
    public class RandevuRepository : EFRepositoryBase<Randevular, HastaneEntities>, IRandevuRepository
    {
        public RandevuRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }

        public int GetRandevuCount()
        {
            return _dbSet.Count(x => x.Geldimi == false);
        }
    }
}
