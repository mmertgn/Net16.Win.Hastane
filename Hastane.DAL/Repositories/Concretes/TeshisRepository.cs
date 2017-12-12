using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Data.Entity;
using System.Linq;

namespace Hastane.DAL.Repositories.Concretes
{
    public class TeshisRepository : EFRepositoryBase<Teshisler,HastaneEntities>,ITeshisRepository
    {
        public TeshisRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public Teshisler GetTeshisByKabulId(int kabulId)
        {
            return _dbSet.FirstOrDefault(x => x.KabulID == kabulId);
        }
    }
}
