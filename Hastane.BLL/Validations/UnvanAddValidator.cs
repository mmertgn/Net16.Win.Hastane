using FluentValidation;
using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Validations
{
    public class UnvanAddValidator : AbstractValidator<Unvanlar>
    {
        public UnvanAddValidator()
        {
            RuleFor(x => x.PersonelUnvan).Must(SameIsNotExist).WithMessage("Aynı Kurum Var!");
        }

        private bool SameIsNotExist(string personelUnvan)
        {
            using (var hstn = new HastaneEntities())
            {
                return hstn.Unvanlar.Any(x => x.PersonelUnvan != personelUnvan);
            }
        }
    }

    public class UnvanUpdateValidator : AbstractValidator<Unvanlar>
    {
        public UnvanUpdateValidator()
        {
            RuleFor(x => x.PersonelUnvan).NotEmpty().WithMessage("Personel unvanını girmek zorundasınız!");
        }

    }
    public class UnvanDeleteValidator : AbstractValidator<Unvanlar>
    {
        public UnvanDeleteValidator()
        {
        }

    }
}
