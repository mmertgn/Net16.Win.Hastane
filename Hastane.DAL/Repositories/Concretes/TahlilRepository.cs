using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.DAL.Repositories.Concretes
{
    public class TahlilRepository : EFRepositoryBase<Tahliller,HastaneEntities>,ITahlilRepository
    {
        public TahlilRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }

        public int GetTahlilCount()
        {
            return _dbSet.Count();
        }
    }
}
