using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Data.Entity;
using System.Linq;

namespace Hastane.DAL.Repositories.Concretes
{
    public class HastaSikayetleriRepository : EFRepositoryBase<HastaSikayetleri, HastaneEntities>, IHastaSikayetleriRepository
    {
        public HastaSikayetleriRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public HastaSikayetleri GetHastaSikayetleriByKabulId(int kabulId)
        {
            return _dbSet.FirstOrDefault(x => x.KabulID == kabulId);
        }
    }
}
