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
   public class TeshisRepository : EFRepositoryBase<Teshisler,HastaneEntities>,ITeshisRepository
    {
        public TeshisRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public Teshisler GetTeshisByKabulId(int kabulId)
        {
            return _dbSet.FirstOrDefault(x => x.KabulID == kabulId);
        }
    }
}
