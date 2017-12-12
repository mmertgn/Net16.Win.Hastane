using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.DAL.Repositories.Concretes
{
    public class IlceRepository : EFRepositoryBase<ilceler,HastaneEntities>,IIlceRepository
    {
        public IlceRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }
    }
}
