using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Models;
using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Hastane.BLL.Validations;
using FluentValidation.Results;
using FluentValidation;

namespace Hastane.BLL.Services.Concretes
{
    public class PersonelService : IPersonelService
    {
        private readonly IPersonelRepository _personelRepo;
        

        public PersonelService(IPersonelRepository personelRepo)
        {
            _personelRepo = personelRepo;
           
        }

        public MessageResult Create(Personeller model)
        {
            var _validator = new PersonelAddValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
                _personelRepo.Add(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Personel Ekleme İşlemi Başarıyla Sonuçlandırılmıştır." : "Hatalı bilgiler mevcut";
            return m;
        }

        public MessageResult Delete(int id)
        {
            _personelRepo.Delete(id);
            var m = new MessageResult
            {
                IsSucceed = true
            };
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt Silme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public List<Personeller> DoktorDoldurByKlinikFromRandevu(string cbKlinikText)
        {
            return _personelRepo.GetList(x => x.Klinikler.KlinikAd == cbKlinikText);         
        }

        public MessageResult Edit(Personeller model)
        {
            var _validator = new PersonelUpdateValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
               _personelRepo.Update(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Personel Güncelleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public Personeller GetPersonelFindById(int id)
        {
            return _personelRepo.FindById(id);
        }

       

        List<PersonelListeleOzel> IPersonelService.PersonelleriOzelListele(string AdSoyad, string PersonelKod)
        {
            var model = _personelRepo.GetList(x => (x.Ad + " " + x.Soyad).Contains(AdSoyad) && x.PersonelKodu.Contains(PersonelKod) && x.Siilindi == false)
                .Select(x => new PersonelListeleOzel()
                {
                    
                    PersonelID = x.PersonelID,
                   PersonelAd=x.Ad,
                   PersonelSoyad=x.Soyad,
                   PersonelKod=x.PersonelKodu
                }).ToList();
            return model;
        }

        List<PersonelListeleFromPersonel> IPersonelService.PersonelListele()
        {
            var model = _personelRepo.GetList(x => x.Siilindi == false).Select(x => new PersonelListeleFromPersonel
            {
                PersonelID = x.PersonelID,
                UnvanID = x.UnvanID,
                KlinikID = x.KlinikID,
                PersonelKod = x.PersonelKodu,
                TCKNo = x.TCKimlikNo,
                DogumTarihi=x.DogumTarihi,
                SicilNo = x.SicilNo,
                PersonelAd = x.Ad,
                PersonelSoyad = x.Soyad,
                EMail = x.Email,
                Adres = x.Adres,
                EvTel = x.EvTel,
                CepTel = x.CepTel,
                SilindiMi = x.Siilindi

            }).ToList();
            return model;
        }

        
    }
}
