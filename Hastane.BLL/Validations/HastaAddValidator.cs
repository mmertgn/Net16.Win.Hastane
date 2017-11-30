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

        public bool SameIsNotExist(string TCKimlikNo)
        {
            using (HastaneEntities hstn = new HastaneEntities())
            {
                return hstn.Hastalar.Any(x => x.TCKimlikNo != TCKimlikNo);
            }
        }
    }
}
