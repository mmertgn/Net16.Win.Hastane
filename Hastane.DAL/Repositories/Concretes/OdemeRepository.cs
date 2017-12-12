using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Data.Entity;

namespace Hastane.DAL.Repositories.Concretes
{
    public class OdemeRepository : EFRepositoryBase<Odemeler,HastaneEntities>,IOdemeRepository
    {
        public OdemeRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
