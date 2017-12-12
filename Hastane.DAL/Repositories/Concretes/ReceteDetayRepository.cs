using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Data.Entity;

namespace Hastane.DAL.Repositories.Concretes
{
    public class ReceteDetayRepository : EFRepositoryBase<ReceteDetay,HastaneEntities>,IReceteDetayRepository
    {
        public ReceteDetayRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
