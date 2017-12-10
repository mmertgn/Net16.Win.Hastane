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
    public class TahlilIcerikService : ITahlilIcerikService
    {
        private readonly ITahlilIcerikRepository _tahlilIcerikRepository;

        public TahlilIcerikService(ITahlilIcerikRepository tahlilIcerikRepository)
        {
            _tahlilIcerikRepository = tahlilIcerikRepository;
        }
        public MessageResult Create(TahlilIcerik model)
        {
            var _validator = new TahlilIcerikAddValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
                _tahlilIcerikRepository.Add(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Tahlil Ekleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }
    }
}
