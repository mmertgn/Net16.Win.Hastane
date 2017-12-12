using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Data.Entity;

namespace Hastane.DAL.Repositories.Concretes
{
    public class HastaKabulRepository : EFRepositoryBase<HastaKabul,HastaneEntities>,IHastaKabulRepository
    {
        public HastaKabulRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
