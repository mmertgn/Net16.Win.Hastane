using Hastane.BLL.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Models;
using Hastane.DAL.DataModel;
using System.Linq.Expressions;
using Hastane.DAL.Repositories.Abstracts;
using Hastane.BLL.Validations;
using FluentValidation.Results;

namespace Hastane.BLL.Services.Concretes
{
    public class HizmetService : IHizmetService
    {
        private readonly IHizmetRepository _repo;

        public HizmetService(IHizmetRepository repo)
        {
            _repo = repo;
        }
        public MessageResult Create(Hizmetler model)
        {
            var _validator = new HizmetAddValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
                _repo.Add(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Hizmet Ekleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }
        public Hizmetler GetHizmetByName(string HizmetAdi)
        {
            return _repo.GetList(x => (x.Klinikler.KlinikAd + "-" + x.HizmetAdi == HizmetAdi)).FirstOrDefault();
        }

        public MessageResult Delete(int id)
        {
            _repo.Delete(id);
            var m = new MessageResult
            {
                IsSucceed = true
            };
            m.SuccessMessage = m.IsSucceed == true ? "Hizmet Silme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public MessageResult Edit(Hizmetler model)
        {
                var _validator = new HizmetUpdateValidator();
                ValidationResult result = _validator.Validate(model);
                if (result.IsValid)
                {
                    _repo.Update(model);
                }
                var m = new MessageResult
                {
                    ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                    IsSucceed = result.IsValid
                };
                m.SuccessMessage = m.IsSucceed == true ? "Hizmet Güncelleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
                return m;
        }

        public Hizmetler GetHizmetById(int id)
        {
            return _repo.FindById(id);
        }

        public List<HizmetListesiModelFromSistemYonetim> HizmetBilgisiDoldur()
        {
            var model = _repo.GetList().Select(x => new HizmetListesiModelFromSistemYonetim
            {
                HizmetId = x.HizmetID,
                HizmetAd = x.HizmetAdi,
                KlinikId = x.KlinikID,
                Ucret = x.Ucret,
                HizmetAciklama=x.Aciklama

            }).ToList();
            return model;
        }

        public List<HizmetListesiModelFromSistemYonetim> HizmetBilgisiDoldurAra(string HizmetAd)
        {
            var model = _repo.GetList(x => (x.HizmetAdi).Contains(HizmetAd))
              .Select(x => new HizmetListesiModelFromSistemYonetim
              {
                  HizmetId = x.HizmetID,
                  HizmetAd = x.HizmetAdi,
                  KlinikId=x.KlinikID,
                  Ucret = x.Ucret,
                  HizmetAciklama=x.Aciklama

              }).ToList();
            return model;
        }

        public List<Hizmetler> HizmetList()
        {
            return _repo.GetList(null);
        }

        public List<Hizmetler> HizmetListWithSorgu(Expression<Func<Hizmetler, bool>> predicate)
        {
            return _repo.GetList(predicate);
        }
    }
}
