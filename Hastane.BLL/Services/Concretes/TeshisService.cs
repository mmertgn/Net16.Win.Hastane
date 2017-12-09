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
    public class TeshisService : ITeshisService
    {
        private readonly ITeshisRepository _teshisRepository;

        public TeshisService(ITeshisRepository teshisRepository)
        {
            _teshisRepository = teshisRepository;
        }

        public MessageResult Create(Teshisler model)
        {
            var _validator = new TeshisAddValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
               _teshisRepository.Add(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt Ekleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public MessageResult Edit(Teshisler model)
        {
            var _validator = new TeshisUpdateValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
                _teshisRepository.Update(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt Güncelleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public Teshisler GetTeshisByKabulId(int kabulId)
        {
            return _teshisRepository.GetTeshisByKabulId(kabulId);
        }
    }
}
