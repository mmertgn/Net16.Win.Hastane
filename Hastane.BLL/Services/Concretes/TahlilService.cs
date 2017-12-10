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
   public  class TahlilService : ITahlilService
   {
       private readonly ITahlilRepository _tahlilRepository;

       public TahlilService(ITahlilRepository tahlilRepository)
       {
           _tahlilRepository = tahlilRepository;
       }

       public MessageResult Create(Tahliller model)
       {
           var _validator = new TahlilAddValidator();
           ValidationResult result = _validator.Validate(model);
           if (result.IsValid)
           {
               _tahlilRepository.Add(model);
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
