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
    public class ReceteService : IReceteService
    {
        private readonly IReceteRepository _receteRepository;

        public ReceteService(IReceteRepository receteRepository)
        {
            _receteRepository = receteRepository;
        }

        public MessageResult Create(Receteler model)
        {
            var _validator = new ReceteAddValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
                _receteRepository.Add(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Reçete Başarıyla Oluşturuldu Aşağıdan İlaçları Ekleyiniz." : "Hatalı bilgiler mevcut";
            return m;
        }

        public int GetReceteId(int secilenHastaKabulId)
        {
            return _receteRepository.GetReceteByKabulId(secilenHastaKabulId).ReceteID;
        }
    }
}
