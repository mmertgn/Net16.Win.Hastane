using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Validations
{
    public class ReceteDetayAddValidator : AbstractValidator<ReceteDetay>
    {
        public ReceteDetayAddValidator()
        {
            RuleFor(x => x.İlacAd).NotEmpty().WithMessage("İlaç adını girmek zorundasınız!");
            RuleFor(x => x.İlacKullanimSikligi).NotEmpty().WithMessage("Yazılan ilaç için bir kullanım sıklığı girmek zorundasınız!");
        }
    }
}
