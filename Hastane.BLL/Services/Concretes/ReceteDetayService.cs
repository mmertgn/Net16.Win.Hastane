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
    public class ReceteDetayService : IReceteDetayService
    {
        private readonly IReceteDetayRepository _receteDetayRepository;

        public ReceteDetayService(IReceteDetayRepository receteDetayRepository)
        {
            _receteDetayRepository = receteDetayRepository;
        }
        public MessageResult Create(ReceteDetay model)
        {
            var _validator = new ReceteDetayAddValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
                _receteDetayRepository.Add(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt Ekleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public List<ReceteDetayModel> ReceteDetayListesi(int receteId)
        {
            var model = _receteDetayRepository.GetList(x=>x.ReceteID==receteId).Select(x => new ReceteDetayModel
            {
                ReceteDetayId = x.ReceteDetayID,
                IlacAd = x.İlacAd,
                IlacKullanimSikligi = x.İlacKullanimSikligi
            }).ToList();
            return model;
        }
    }
}
