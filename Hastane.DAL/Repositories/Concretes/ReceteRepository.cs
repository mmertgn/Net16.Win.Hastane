using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

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
