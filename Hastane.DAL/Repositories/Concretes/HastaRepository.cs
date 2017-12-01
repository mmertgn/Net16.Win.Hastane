using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.DAL.Repositories.Concretes
{
    public class HastaRepository : EFRepositoryBase<Hastalar,HastaneEntities>,IHastaRepository
    {
        public HastaRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }
    }
}
