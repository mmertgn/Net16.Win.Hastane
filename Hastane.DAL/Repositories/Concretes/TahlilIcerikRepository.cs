using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Data.Entity;

namespace Hastane.DAL.Repositories.Concretes
{
    public class TahlilIcerikRepository : EFRepositoryBase<TahlilIcerik,HastaneEntities>,ITahlilIcerikRepository
    {
        public TahlilIcerikRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
