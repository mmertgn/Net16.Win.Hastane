using Hastane.BLL.Infrastructure.Messaging.Abstracts;
using Hastane.BLL.Models;
using Hastane.BLL.Services.Abstracts;
using Hastane.BLL.Validations;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using System.Collections.Generic;
using System.Linq;

namespace Hastane.BLL.Services.Concretes
{
    public class PersonelService : IPersonelService
    {
        private readonly IPersonelRepository _personelRepo;

        private readonly IMessaging _messageService;
        public PersonelService(IPersonelRepository personelRepo, IMessaging messageService)
        {
            _personelRepo = personelRepo;
            _messageService = messageService;
        }
        public PersonelService(IPersonelRepository personelRepo)
        {
            _personelRepo = personelRepo;
        }
        public List<Personeller> DoktorDoldurByKlinikFromRandevu(string cbKlinikText)
        {
            return _personelRepo.GetList(x => x.Klinikler.KlinikAd == cbKlinikText);
        }
        public MessageResult Create(Personeller model)
        {
            var _validator = new PersonelAddValidator();
            var result = _validator.Validate(model);
            if (result.IsValid)
            {
                _personelRepo.Add(model);
                //Mail sistemi gerektiğinde açılcak
                //if (_messageService != null)
                //{
                //    var msg = new MessageTemplate
                //    {
                //        From = "HastaneYonetimSistemi",
                //        To = new List<string> {model.Email},
                //        MessageBody = "Kullanıcı Adınız : " + model.KullaniciAdi + "\n" + "Şifreniz : " + model.Sifre,
                //        MessageSubject = "Kullanıcı Adı ve Şifreniz"
                //    };

                //    _messageService.SendMessage(msg);
                //}
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Personel Ekleme İşlemi Başarıyla Sonuçlandırılmıştır. Kullanıcı Adı ve Şifre Bilgileri Mail Adresine Gönderilmiştir." : "Hatalı bilgiler mevcut";
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

        public MessageResult Edit(Personeller model)
        {
            var _validator = new PersonelUpdateValidator();
            var result = _validator.Validate(model);
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


        public List<PersonelListeleFromPersonel> PersonelleriOzelListele(string AdSoyad, string PersonelKod)
        {
            var model = _personelRepo.GetList(x => (x.Ad + " " + x.Soyad).Contains(AdSoyad) && x.PersonelKodu.Contains(PersonelKod) && x.Siilindi == false)
                .Select(x => new PersonelListeleFromPersonel()
                {
                    PersonelID = x.PersonelID,
                    UnvanID = x.UnvanID,
                    KlinikID = (int)x.KlinikID,
                    PersonelKod = x.PersonelKodu,
                    TCKNo = x.TCKimlikNo,
                    DogumTarihi = x.DogumTarihi,
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

        public List<PersonelListeleFromPersonel> PersonelListele()
        {
            var model = _personelRepo.GetList(x => x.Siilindi == false).Select(x => new PersonelListeleFromPersonel
            {
                PersonelID = x.PersonelID,
                UnvanID = x.UnvanID,
                KlinikID = (int)x.KlinikID,
                PersonelKod = x.PersonelKodu,
                TCKNo = x.TCKimlikNo,
                DogumTarihi = x.DogumTarihi,
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
