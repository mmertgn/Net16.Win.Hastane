using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.BLL.Services.Concretes
{
    public class HastaTahlilSonuclariService : IHastaTahlilSonuclariService
    {
        private readonly IHastaTahlilSonuclariRepository _hastaTahlilSonuclariRepository;

        public HastaTahlilSonuclariService(IHastaTahlilSonuclariRepository hastaTahlilSonuclariRepository)
        {
            _hastaTahlilSonuclariRepository = hastaTahlilSonuclariRepository;
        }

        public List<HastaTahlilSonuclari> HizmetList()
        {
            return _hastaTahlilSonuclariRepository.GetList(null);
        }

        public List<HastaTahlilSonuclari> HizmetListWithSorgu(Expression<Func<HastaTahlilSonuclari, bool>> predicate)
        {
            return _hastaTahlilSonuclariRepository.GetList(predicate);
        }
    }
}
