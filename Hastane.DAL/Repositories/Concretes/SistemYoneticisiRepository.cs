using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

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
