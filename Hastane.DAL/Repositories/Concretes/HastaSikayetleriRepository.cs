using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.DAL.Repositories.Concretes
{
    public class HastaSikayetleriRepository : EFRepositoryBase<HastaSikayetleri, HastaneEntities>, IHastaSikayetleriRepository
    {
        public HastaSikayetleriRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public HastaSikayetleri GetHastaSikayetleriByKabulId(int kabulId)
        {
            return _dbSet.FirstOrDefault(x => x.KabulID == kabulId);
        }
    }
}
