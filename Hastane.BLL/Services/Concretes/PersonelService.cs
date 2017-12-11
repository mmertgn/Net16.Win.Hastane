using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.BLL.Services.Concretes
{
    public class PersonelService : IPersonelService
    {
        private readonly IPersonelRepository _personelRepo;

        public PersonelService(IPersonelRepository personelRepo)
        {
            _personelRepo = personelRepo;
        }

        public List<Personeller> DoktorDoldurByKlinikFromRandevu(string cbKlinikText)
        {
            return _personelRepo.GetList(x => x.Klinikler.KlinikAd == cbKlinikText);         
        }

        
    }
}
