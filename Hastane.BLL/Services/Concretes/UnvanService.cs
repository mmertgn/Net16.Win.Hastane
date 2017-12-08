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
    public class UnvanService : IUnvanService

    {
        private readonly IUnvanRepository _repo;

        public UnvanService(IUnvanRepository repo)
        {
            _repo = repo;
        }
        public MessageResult Create(Unvanlar model)
        {
            var _validator = new UnvanAddValidator();
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
            m.SuccessMessage = m.IsSucceed == true ? "Unvan Ekleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public MessageResult Delete(int id)
        {
            _repo.Delete(id);
            var m = new MessageResult
            {
                IsSucceed = true
            };
            m.SuccessMessage = m.IsSucceed == true ? "Unvan Silme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public MessageResult Edit(Unvanlar model)
        {
            var kontrol = _repo.GetList(x => x.UnvanID != model.UnvanID && x.PersonelUnvan == model.PersonelUnvan).Count;
            if (Convert.ToBoolean(kontrol))
            {
                var msg = new MessageResult();
                msg.ErrorMessage = new List<string> { "Bu Unvan zaten var." };
                return msg;
            }

            else
            {
                var _validator = new UnvanUpdateValidator();
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
                m.SuccessMessage = m.IsSucceed == true ? "Unvan Güncelleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
                return m;
            }
        }

        public Unvanlar GetUnvanById(int id)
        {
            return _repo.FindById(id);
        }

        public List<Unvanlar> UnvanList()
        {
            return _repo.GetList(null);
        }

        public List<Unvanlar> UnvanListWithSorgu(Expression<Func<Unvanlar, bool>> predicate)
        {
            return _repo.GetList(predicate);
        }
    }
}
