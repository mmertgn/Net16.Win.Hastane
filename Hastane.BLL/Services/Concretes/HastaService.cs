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
    public class HastaService : IHastaService
    {
        private readonly IHastaRepository _repo;
        public HastaService(IHastaRepository repo)
        {
            _repo = repo;
        }
        public MessageResult Create(Hastalar model)
        {
            var _validator = new HastaAddValidator();
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
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt Ekleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public MessageResult Delete(int id)
        {
            _repo.Delete(id);
            var m = new MessageResult
            {
                IsSucceed = true
            };
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt Silme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public MessageResult Edit(Hastalar model)
        {
            var _validator = new HastaUpdateValidator();
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
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt Güncelleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public Hastalar GetHastaById(int id)
        {
            return _repo.FindById(id);
        }

        public List<Hastalar> HastaList()
        {
            return _repo.GetList(null);
        }
        

        public List<Hastalar> HastaListWithSorgu(Expression<Func<Hastalar, bool>> predicate)
        {
            return _repo.GetList(predicate);
        }
    }

}
