using FluentValidation;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Validations
{
    public class HastaKabulAddValidator : AbstractValidator<HastaKabul>
    {
        public HastaKabulAddValidator()
        {
            
        }
        
    }

    public class HastaKabulUpdateValidator : AbstractValidator<HastaKabul>
    {
        public HastaKabulUpdateValidator() //Bu metot Doktor işlemlerinde doktor hastadan tahlilleri isterken çalışmaktadır.
        {
            RuleFor(x => x.IstenenTahliller).NotEmpty().WithMessage("Hastadan istenen tahlilleri girmek zorundasınız!");
        }

    }
}
