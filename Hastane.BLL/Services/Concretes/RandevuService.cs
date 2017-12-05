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
    public class RandevuService : IRandevuService
    {
        private readonly IRandevuRepository _randevuRepository;

        public RandevuService(IRandevuRepository randevuRepository)
        {
            _randevuRepository = randevuRepository;
        }

        public MessageResult Create(Randevular model)
        {
            var _validator = new RandevuAddValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
                _randevuRepository.Add(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Hastamızın Randevu Ekleme İşlemi Başarıyla Sonuçlandırılmıştır." : "Hatalı bilgiler mevcut";
            return m;
        }

        public List<string> DoktoraAitRandevular(string cbDoktorSelectedValue, DateTime RandevuTarihi)
        {
            var model = _randevuRepository.GetList(x => (x.Personeller.Unvanlar.PersonelUnvan + " " + x.Personeller.Ad + " " + x.Personeller.Soyad) == cbDoktorSelectedValue && x.Tarih==RandevuTarihi);
            List<string> randevuSaatleri = new List<string>();
            model.ForEach(item =>
            {
                randevuSaatleri.Add(item.Saat);
            });
            return randevuSaatleri;
        }
    }
}
