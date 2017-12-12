using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Linq;

namespace Hastane.DAL.Repositories.Concretes
{
    public class HizmetRepository : EFRepositoryBase<Hizmetler, HastaneEntities>, IHizmetRepository
    {
        public HizmetRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }

        public int GetHizmetCount()
        {
            return _dbSet.Count();
        }
    }
}
