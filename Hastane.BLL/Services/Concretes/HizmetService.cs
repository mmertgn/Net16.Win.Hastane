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
            var kontrol = _repo.GetList(x => x.HizmetID != model.HizmetID && x.HizmetAdi == model.HizmetAdi).Count;
            if (Convert.ToBoolean(kontrol))
            {
                var msg = new MessageResult();
                msg.ErrorMessage = new List<string> { "Bu Hizmet zaten var." };
                return msg;
            }

            else
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
        }

        public Hizmetler GetHizmetById(int id)
        {
            return _repo.FindById(id);
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
