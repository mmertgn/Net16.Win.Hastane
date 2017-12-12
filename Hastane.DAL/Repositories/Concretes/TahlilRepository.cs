using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Collections.Generic;
using System.Linq;

namespace Hastane.DAL.Repositories.Concretes
{
    public class TahlilRepository : EFRepositoryBase<Tahliller,HastaneEntities>,ITahlilRepository
    {
        public TahlilRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }

        public int GetTahlilCount()
        {
            return _dbSet.Count();
        }

        public List<Tahliller> TahlilGetir(string TahlilAdi)
        {
            return _dbSet.Where(x => x.TahlilAdi == TahlilAdi).ToList();
        }
    }
}
