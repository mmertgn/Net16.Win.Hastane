using System.Linq;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.DAL.Repositories.Concretes
{
    public class PersonelRepository : EFRepositoryBase<Personeller,HastaneEntities>, IPersonelRepository
    {
        public PersonelRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }

        public int GetDoktorCount()
        {
            return _dbSet.Count(x => x.Unvanlar.PersonelUnvan == "Doktor");
        }

        public int GetSekreterCount()
        {
            return _dbSet.Count(x => x.Unvanlar.PersonelUnvan == "Sekreter");
        }
    }
}