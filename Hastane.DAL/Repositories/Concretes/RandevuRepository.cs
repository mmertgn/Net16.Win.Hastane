using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System;
using System.Linq;

namespace Hastane.DAL.Repositories.Concretes
{
    public class RandevuRepository : EFRepositoryBase<Randevular, HastaneEntities>, IRandevuRepository
    {
        public RandevuRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }

        public int GetRandevuCount()
        {
            DateTime date = DateTime.Now.Date;
            return _dbSet.Count(x => x.Geldimi == false && x.Tarih==date);
        }
    }
}
