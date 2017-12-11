using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using Hastane.BLL.Models;
using Hastane.BLL.Services.Abstracts;
using Hastane.BLL.Validations;
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
        public Randevular GetRandevuById(int id)
        {
            return _randevuRepository.FindById(id);
        }
        public MessageResult Create(Randevular model)
        {
            var _validator = new RandevuAddValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
                _randevuRepository.Add(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Hastamızın Randevu Ekleme İşlemi Başarıyla Sonuçlandırılmıştır." : "Hatalı bilgiler mevcut";
            return m;
        }

        public List<string> DoktoraAitRandevular(string cbDoktorSelectedValue, DateTime RandevuTarihi)
        {
            var model = _randevuRepository.GetList(x => (x.Personeller.Unvanlar.PersonelUnvan + " " + x.Personeller.Ad + " " + x.Personeller.Soyad) == cbDoktorSelectedValue && x.Tarih == RandevuTarihi);
            List<string> randevuSaatleri = new List<string>();
            model.ForEach(item =>
            {
                randevuSaatleri.Add(item.Saat);
            });
            return randevuSaatleri;
        }


        public List<RandevuListeleFromHastaKabul> RandevuListele()
        {
            var model = _randevuRepository.GetList(x=>x.Geldimi==false).Select(x => new RandevuListeleFromHastaKabul
            {
                RandevuId = x.RandevuID,
                HastaId = x.HastaID,
                PersonelId = x.PersonelID,
                AdSoyad = x.Hastalar.Ad + " " + x.Hastalar.Soyad,
                TCKimlikNo = x.Hastalar.TCKimlikNo,
                DoktorAdi = (x.Personeller.Unvanlar.PersonelUnvan + " " + x.Personeller.Ad + " " + x.Personeller.Soyad),
                RandevuTarihi = x.Tarih,
                Saat=x.Saat,
                GeldiMi=x.Geldimi,
                KlinikAdi = x.Personeller.Klinikler.KlinikAd

            }).ToList();
            return model;
        }

        public List<RandevuListeleFromHastaKabul> RandevuListesiAra(string AdSoyad, string TcKimlikNo)
        {
             
            var model = _randevuRepository.GetList(x => (x.Hastalar.Ad + " " + x.Hastalar.Soyad).Contains(AdSoyad) &&x.Hastalar.TCKimlikNo.Contains(TcKimlikNo)&&x.Geldimi==false)
                .Select(x => new RandevuListeleFromHastaKabul
                {
                    RandevuId = x.RandevuID,
                    HastaId = x.HastaID,
                    PersonelId = x.PersonelID,
                    AdSoyad = x.Hastalar.Ad + " " + x.Hastalar.Soyad,
                    TCKimlikNo = x.Hastalar.TCKimlikNo,
                    
                    RandevuTarihi = x.Tarih,
                  
                    DoktorAdi = (x.Personeller.Unvanlar.PersonelUnvan + " " + x.Personeller.Ad + " " + x.Personeller.Soyad)
                }).ToList();
            return model;
        }
    
        public MessageResult Edit(Randevular model)
        {

            var _validator = new RandevuAddValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
                _randevuRepository.Update(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Hasta Kabul Güncelleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }
    }
}
