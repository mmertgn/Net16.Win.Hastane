using FluentValidation;
using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Validations
{
    public class HastaAddValidator : AbstractValidator<Hastalar>
    {
        public HastaAddValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Hastanın adını girmek zorundasınız!");
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Hastanın soyadını girmek zorundasınız!");
            RuleFor(x => x.TCKimlikNo).NotEmpty().WithMessage("Hastanın TC Kimlik Numarasını girmek zorundasınız!");
            RuleFor(x => x.TCKimlikNo).Must(SameIsNotExist).WithMessage("Aynı TC No ile ekli bir hasta var!");
        }

        public bool SameIsNotExist(string tcKimlikNo)
        {
            using (var hstn = new HastaneEntities())
            {
                return hstn.Hastalar.Any(x => x.TCKimlikNo != tcKimlikNo);
            }
        }
    }
    public class HastaUpdateValidator : AbstractValidator<Hastalar>
    {
        public HastaUpdateValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Hastanın Adını girmek zorundasınız!");
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Hastanın Soyadını girmek zorundasınız!");
            RuleFor(x => x.TCKimlikNo).NotEmpty().WithMessage("Hastanın TC Kimlik Numarasını girmek zorundasınız!");
        }
        
    }
    public class HastaKabulUpdateValidator : AbstractValidator<HastaKabul>
    {
        public HastaKabulUpdateValidator()
        {
            RuleFor(x => x.Hastalar.Ad).NotEmpty().WithMessage("Hastanın Adını girmek zorundasınız!");
            RuleFor(x => x.Hastalar.Soyad).NotEmpty().WithMessage("Hastanın Soyadını girmek zorundasınız!");
            RuleFor(x => x.Hastalar.TCKimlikNo).NotEmpty().WithMessage("Hastanın TC Kimlik Numarasını girmek zorundasınız!");
        }

    }
    public class HastaDeleteValidator : AbstractValidator<Hastalar>
    {
        public HastaDeleteValidator()
        {
        }

    }
    public class HastaKabulAddValidator : AbstractValidator<HastaKabul>
    {
        public HastaKabulAddValidator()
        {
        }

    }

}
