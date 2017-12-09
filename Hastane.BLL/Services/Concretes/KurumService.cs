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
    public class KurumService : IKurumService
    {
        private readonly IKurumRepository _repo;
        public KurumService(IKurumRepository repo)
        {
            _repo = repo;
        }
        public MessageResult Create(Kurumlar model)
        {
            var _validator = new KurumAddValidator();
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
            m.SuccessMessage = m.IsSucceed == true ? "Kurum Ekleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public MessageResult Delete(int id)
        {
            _repo.Delete(id);
            var m = new MessageResult
            {
                IsSucceed = true
            };
            m.SuccessMessage = m.IsSucceed == true ? "Kurum Silme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public MessageResult Edit(Kurumlar model)
        {
            var kontrol = _repo.GetList(x => x.KurumID != model.KurumID && x.KurumAd == model.KurumAd).Count;
            if (Convert.ToBoolean(kontrol))
            {
                var msg = new MessageResult();
                msg.ErrorMessage = new List<string> { "Bu Kurum zaten var." };
                return msg;
            }

            else
            {
                var _validator = new KurumUpdateValidator();
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
                m.SuccessMessage = m.IsSucceed == true ? "Kurum Güncelleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
                return m;
            }
        }

        public Kurumlar GetKurumById(int id)
        {
            return _repo.FindById(id);
        }

        public List<KurumListesiModelFromSistemYonetim> KurumBilgisiDoldur()
        {
            var model = _repo.GetList().Select(x => new KurumListesiModelFromSistemYonetim
            {
                KurumId = x.KurumID,
                KurumAd = x.KurumAd,
                KurumIskonto =Convert.ToString( x.Iskonto)

            }).ToList();
            return model;
        }

        public List<KurumListesiModelFromSistemYonetim> KurumBilgisiDoldurAra(string KurumAd, string KurumIskonto)
        {
            var model = _repo.GetList(x => (x.KurumAd).Contains(KurumAd) &&Convert.ToString(x.Iskonto).Contains(KurumIskonto))
               .Select(x => new KurumListesiModelFromSistemYonetim
               {
                   KurumId = x.KurumID,
                   KurumAd = x.KurumAd,
                   KurumIskonto =Convert.ToString(x.Iskonto)

               }).ToList();
            return model;
        }

        public List<Kurumlar> KurumList()
        {
            return _repo.GetList(null);
        }

        public List<Kurumlar> KurumListWithSorgu(Expression<Func<Kurumlar, bool>> predicate)
        {
            return _repo.GetList(predicate);
        }
    }
}
