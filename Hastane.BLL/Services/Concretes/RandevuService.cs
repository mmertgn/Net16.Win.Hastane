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
    public class RandevuService : IRandevuService
    {
        private readonly IRandevuRepository _randevuRepository;

        public RandevuService(IRandevuRepository randevuRepository)
        {
            _randevuRepository = randevuRepository;
        }

        public List<string> DoktoraAitRandevular(string cbDoktorSelectedValue, DateTime RandevuTarihi)
        {
            var model = _randevuRepository.GetList(x => (x.Personeller.Unvanlar.PersonelUnvan + " " + x.Personeller.Ad + " " + x.Personeller.Soyad) == cbDoktorSelectedValue && x.Tarih.ToShortDateString()==RandevuTarihi.ToShortDateString());
            List<string> randevuSaatleri = new List<string>();
            model.ForEach(item =>
            {
                randevuSaatleri.Add(item.Saat);
            });
            return randevuSaatleri;
        }
    }
}
