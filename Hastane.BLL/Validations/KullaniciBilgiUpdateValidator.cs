using FluentValidation;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Validations
{
    public class KullaniciBilgiUpdateValidator : AbstractValidator<Personeller>
    {
        public KullaniciBilgiUpdateValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Adınızı girmek zorundasınız!");
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Soyadınızı girmek zorundasınız!");
            RuleFor(x => x.TCKimlikNo).NotEmpty().WithMessage("TC Kimlik Numarasını girmek zorundasınız!");
        }
    }
}
