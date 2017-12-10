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
    public class TahlilIcerikRepository : EFRepositoryBase<TahlilIcerik,HastaneEntities>,ITahlilIcerikRepository
    {
        public TahlilIcerikRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
