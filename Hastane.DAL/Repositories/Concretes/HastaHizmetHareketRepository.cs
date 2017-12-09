using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Data.Entity;

namespace Hastane.DAL.Repositories.Concretes
{
    public class HastaHizmetHareketRepository : EFRepositoryBase<HastaHizmetHareketler,HastaneEntities>,IHastaHizmetHareketRepository
    {
        public HastaHizmetHareketRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
