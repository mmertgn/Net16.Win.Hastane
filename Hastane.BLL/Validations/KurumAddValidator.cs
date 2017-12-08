using FluentValidation;
using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Validations
{
    public class KurumAddValidator : AbstractValidator<Kurumlar>
    {
        public KurumAddValidator()
        {
            RuleFor(x => x.KurumAd).Must(SameIsNotExist).WithMessage("Aynı Kurum Var!");
        }

        private bool SameIsNotExist(string kurumAd)
        {
            using (var hstn = new HastaneEntities())
            {
                return hstn.Kurumlar.Any(x => x.KurumAd != kurumAd);
            }
        }
    }

    public class KurumUpdateValidator : AbstractValidator<Kurumlar>
        {
            public KurumUpdateValidator()
            {
                RuleFor(x => x.KurumAd).NotEmpty().WithMessage("Kurum adını girmek zorundasınız!");
            }

        }
        public class KurumDeleteValidator : AbstractValidator<Kurumlar>
        {
            public KurumDeleteValidator()
            {
            }

        }
    
}
