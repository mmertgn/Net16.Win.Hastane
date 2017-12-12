using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Data.Entity;
using System.Linq;

namespace Hastane.DAL.Repositories.Concretes
{
    public class ReceteRepository : EFRepositoryBase<Receteler, HastaneEntities>, IReceteRepository
    {
        public ReceteRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public Receteler GetReceteByKabulId(int secilenHastaKabulId)
        {
            return _dbSet.FirstOrDefault(x => x.KabulID == secilenHastaKabulId);
        }
    }
}
