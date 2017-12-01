using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.DAL.Repositories.Concretes
{
    public class PersonelRepository : EFRepositoryBase<Personeller,HastaneEntities>, IPersonelRepository
    {
        public PersonelRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }
    }
}