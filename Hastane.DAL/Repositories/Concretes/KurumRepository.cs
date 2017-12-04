using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.DAL.Repositories.Concretes
{
    public class KurumRepository : EFRepositoryBase<Kurumlar,HastaneEntities>,IKurumRepository
    {
        public KurumRepository(HastaneEntities dbContext) : base(dbContext)
        {
        }

        public int GetKurumCount()
        {
            return _dbSet.Count();
        }
        public List<Kurumlar> KurumGetir(string KurumAdi)
        {
            return _dbSet.Where(x => x.KurumAd == KurumAdi).ToList();
        }
    }
}
