using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Validations
{
    public class TahlilIcerikAddValidator : AbstractValidator<TahlilIcerik>
    {
        public TahlilIcerikAddValidator()
        {
            RuleFor(x => x.TahlilIcerikAdi).NotEmpty().WithMessage("Tahlil İçerik adını girmek zorundasınız!");
            RuleFor(x => x.TahlilIcerikReferansDegeri).NotEmpty().WithMessage("Tahlil Referans değerini girmek zorundasınız!");
            RuleFor(x => x.TahlilSonucBirimi).NotEmpty().WithMessage("Tahlil birimini girmek zorundasınız!");
        }
    }
}
