using FluentValidation;
using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Validations
{
    public class KlinikAddValidator : AbstractValidator<Klinikler>
    {
        public KlinikAddValidator()
        {
          
            RuleFor(x => x.KlinikAd).Must(SameIsNotExist).WithMessage("Aynı Klinik Var!");
        }

        public bool SameIsNotExist(string klinikAd)
        {
            using (var hstn = new HastaneEntities())
            {
                return hstn.Klinikler.Any(x => x.KlinikAd != klinikAd);
            }
        }
    }
    public class KlinikUpdateValidator : AbstractValidator<Klinikler>
    {
        public KlinikUpdateValidator()
        {
            RuleFor(x => x.KlinikAd).NotEmpty().WithMessage("Klinik adını girmek zorundasınız!");
        }

    }
    public class KlinikDeleteValidator : AbstractValidator<Klinikler>
    {
        public KlinikDeleteValidator()
        {
        }

    }
}
