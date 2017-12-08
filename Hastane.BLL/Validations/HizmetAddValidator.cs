using FluentValidation;
using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Validations
{
    public class HizmetAddValidator : AbstractValidator<Hizmetler>
    {
        public HizmetAddValidator()
        {
            RuleFor(x => x.HizmetAdi).NotEmpty().WithMessage("Hizmet adını girmek zorundasınız!");
            RuleFor(x => x.Ucret).NotEmpty().WithMessage("Ücreti girmek zorundasınız!");
            RuleFor(x => x.KlinikID).NotEmpty().WithMessage("Klinik seçmek zorundasınız!");
           
        }
    }
    public class HizmetUpdateValidator : AbstractValidator<Hizmetler>
    {
        public HizmetUpdateValidator()
        {
            RuleFor(x => x.HizmetAdi).NotEmpty().WithMessage("Hizmet adını girmek zorundasınız!");
            RuleFor(x => x.Ucret).NotEmpty().WithMessage("Ücreti girmek zorundasınız!");
            RuleFor(x => x.KlinikID).NotEmpty().WithMessage("Klinik seçmek zorundasınız!");
        }

    }
    public class HizmetDeleteValidator : AbstractValidator<Hizmetler>
    {
        public HizmetDeleteValidator()
        {
        }

    }
}

