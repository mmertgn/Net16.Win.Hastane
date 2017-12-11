using FluentValidation;
using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Validations
{
    public class PersonelAddValidator : AbstractValidator<Personeller>
    {
        public PersonelAddValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Personel adını girmek zorundasınız!");
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Personel soyadını girmek zorundasınız!");
            RuleFor(x => x.TCKimlikNo).NotEmpty().WithMessage("Personel TC Kimlik Numarasını girmek zorundasınız!");
            RuleFor(x => x.TCKimlikNo).Must(SameIsNotExist).WithMessage("Aynı TC No ile ekli bir personel var!");
            RuleFor(x => x.CepTel).NotEmpty().WithMessage("Personel Cep Telefon Numarasını girmek zorundasınız!");
            
            RuleFor(x => x.DogumTarihi).NotEmpty().WithMessage("Personel Doğum Tarihini girmek zorundasınız!");
           
        }

        public bool SameIsNotExist(string tcKimlikNo)
        {
            using (var hstn = new HastaneEntities())
            {
                return hstn.Personeller.Any(x => x.TCKimlikNo != tcKimlikNo);
            }
        }
    }
    public class PersonelUpdateValidator : AbstractValidator<Personeller>
    {
        public PersonelUpdateValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Personel Adını girmek zorundasınız!");
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Personel Soyadını girmek zorundasınız!");
            RuleFor(x => x.TCKimlikNo).NotEmpty().WithMessage("Personel TC Kimlik Numarasını girmek zorundasınız!");
        }

    }
}
