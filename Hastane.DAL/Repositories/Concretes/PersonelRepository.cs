using System.Collections.Generic;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Linq;

namespace Hastane.DAL.Repositories.Concretes
{
    public class PersonelRepository : EFRepositoryBase<Personeller,HastaneEntities>, IPersonelRepository
    {
        public PersonelRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }

        public int GetDoktorCount()
        {
            return _dbSet.Count(x => x.Unvanlar.PersonelUnvan.Contains("Doktor"));
        }

        public int GetSekreterCount()
        {
            return _dbSet.Count(x => x.Unvanlar.PersonelUnvan.Contains("Sekreter"));
        }
        public List<Personeller> PersonelGetir(int PersonelID)
        {
            return _dbSet.Where(x => x.PersonelID == PersonelID).ToList();
        }
    }
}