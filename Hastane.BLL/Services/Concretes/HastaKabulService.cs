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
    public class HastaKabulService : IHastaKabulService
    {
        private readonly IHastaKabulRepository _hastaKabulRepository;

        public HastaKabulService(IHastaKabulRepository hastaKabulRepository)
        {
            _hastaKabulRepository = hastaKabulRepository;
        }

        public MessageResult Edit(HastaKabul model)
        {
            var _validator = new HastaKabulUpdateValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
                _hastaKabulRepository.Update(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt Güncelleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public HastaKabul GetHastaKabulById(int id)
        {
            return _hastaKabulRepository.FindById(id);
        }
        public List<HastaKabulModelFromDoktorIslemleri> DoktorRandevularıDoldur()
        {
            
            var model = _hastaKabulRepository.GetList(/*x=>x.PersonelID == Genel.LoginKullaniciID*/).Select(x => new HastaKabulModelFromDoktorIslemleri
            {
                KabulId = x.KabulID,
                HastaId = x.HastaID,
                PersonelId = x.PersonelID,
                AdSoyad = x.Hastalar.Ad + " " + x.Hastalar.Soyad,
                TCKimlikNo = x.Hastalar.TCKimlikNo,
                CepTel = x.Hastalar.CepTel,
                RandevuTarihi = x.GelisTarihi,
                Yas = (DateTime.Now.Year - x.Hastalar.DogumTarihi.Value.Year),
                KanGrubu = x.Hastalar.KanGrubu,
                SigortaKurumu = x.Hastalar.Kurumlar.KurumAd,
                KlinikAdi = x.Klinikler.KlinikAd,
                DoktorAdi = (x.Personeller.Unvanlar.PersonelUnvan + " " + x.Personeller.Ad + " " + x.Personeller.Soyad)
            }).ToList();

            return model;
        }

        public List<HastaKabulModelFromDoktorIslemleri> DoktorRandevularıDoldurAra(string HastaAdSoyad,string CepTel,string TcKimlikNo)
        {
            var model = _hastaKabulRepository.GetList(x => (x.Hastalar.Ad + " " + x.Hastalar.Soyad).Contains(HastaAdSoyad) && x.Hastalar.CepTel.Contains(CepTel) && x.Hastalar.TCKimlikNo.Contains(TcKimlikNo))
                .Select(x => new HastaKabulModelFromDoktorIslemleri()
                {
                    KabulId = x.KabulID,
                    HastaId = x.HastaID,
                    PersonelId = x.PersonelID,
                    AdSoyad = x.Hastalar.Ad + " " + x.Hastalar.Soyad,
                    TCKimlikNo = x.Hastalar.TCKimlikNo,
                    CepTel = x.Hastalar.CepTel,
                    RandevuTarihi = x.GelisTarihi,
                    Yas = (DateTime.Now.Year - x.Hastalar.DogumTarihi.Value.Year),
                    KanGrubu = x.Hastalar.KanGrubu,
                    SigortaKurumu = x.Hastalar.Kurumlar.KurumAd,
                    KlinikAdi = x.Klinikler.KlinikAd,
                    DoktorAdi = (x.Personeller.Unvanlar.PersonelUnvan + " " + x.Personeller.Ad + " " + x.Personeller.Soyad)
                }).ToList();
            return model;
        }
    }

    
}
