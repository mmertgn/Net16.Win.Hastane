using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Data.Entity;

namespace Hastane.DAL.Repositories.Concretes
{
    public class HastaTahlilSonuclariRepository : EFRepositoryBase<HastaTahlilSonuclari,HastaneEntities>,IHastaTahlilSonuclariRepository
    {
        public HastaTahlilSonuclariRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
