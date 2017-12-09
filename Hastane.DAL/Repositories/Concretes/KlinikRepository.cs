using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.DAL.Repositories.Concretes
{
    public class KlinikRepository : EFRepositoryBase<Klinikler,HastaneEntities>, IKlinikRepository
    {
        public KlinikRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }

        public int GetKlinikCount()
        {
            return _dbSet.Count();

        }
        public List<Klinikler> KlinikGetir(string KlinikAdi)
        {
            return _dbSet.Where(x => x.KlinikAd == KlinikAdi).ToList();

        }

    }
}
