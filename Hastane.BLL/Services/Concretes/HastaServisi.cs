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
    public class HastaServisi : IHastaServisi
    {
        private readonly IRepository<Hastalar> _repo;
        public HastaServisi(IRepository<Hastalar> repo)
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
            var m = new MessageResult();
            m.ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList();
            m.IsSucceed = result.IsValid;
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt İşlemi Başarılı" : "Hatalı bilgiler mevcut";
            return m;
        }

        public MessageResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public MessageResult Edit(Hastalar model)
        {
            throw new NotImplementedException();
        }

        public Hastalar GetHastaById(int id)
        {
            return _repo.FindById(id);
        }

        public List<Hastalar> HastaList()
        {
            return _repo.GetList(null);
        }

        public int Save()
        {
            return _repo.Save();
        }

        public List<Hastalar> Where(Expression<Func<Hastalar, bool>> predicate)
        {
            return _repo.GetList(predicate);
        }
    }
}
