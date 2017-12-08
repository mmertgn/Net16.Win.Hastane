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
    public class HastaSikayetleriService : IHastaSikayetleriService
    {
        private readonly IHastaSikayetleriRepository _hastaSikayetleriRepository;

        public HastaSikayetleriService(IHastaSikayetleriRepository hastaSikayetleriRepository)
        {
            _hastaSikayetleriRepository = hastaSikayetleriRepository;
        }

        public MessageResult Create(HastaSikayetleri model)
        {
            var _validator = new HastaSikayetiAddValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
                _hastaSikayetleriRepository.Add(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt Ekleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }
        public MessageResult Edit(HastaSikayetleri model)
        {
            var _validator = new HastaSikayetiUpdateValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
                _hastaSikayetleriRepository.Update(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt Güncelleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public HastaSikayetleri GetHastaSikayetleriByKabulId(int kabulId)
        {
            return _hastaSikayetleriRepository.GetHastaSikayetleriByKabulId(kabulId);
        }
    }
}
