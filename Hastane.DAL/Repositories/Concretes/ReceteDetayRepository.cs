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
    public class ReceteDetayRepository : EFRepositoryBase<ReceteDetay,HastaneEntities>,IReceteDetayRepository
    {
        public ReceteDetayRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
