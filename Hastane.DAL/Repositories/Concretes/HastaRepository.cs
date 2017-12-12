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
