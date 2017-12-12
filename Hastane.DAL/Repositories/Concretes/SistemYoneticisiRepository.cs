using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Linq;

namespace Hastane.DAL.Repositories.Concretes
{
    public class SistemYoneticisiRepository : EFRepositoryBase<SistemYoneticileri,HastaneEntities>,ISistemYoneticisiRepository
    {
        public SistemYoneticisiRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }

        public int GetSistemYoneticisiCount()
        {
            return _dbSet.Count();
        }
    }
}
