using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Validations
{
    public class TahlilAddValidator : AbstractValidator<Tahliller>
    {
        public TahlilAddValidator()
        {
            RuleFor(x => x.TahlilAdi).NotEmpty().WithMessage("Tahlil adını girmek zorundasınız!");
            RuleFor(x => x.TahlilUcreti).NotEmpty().WithMessage("Tahlil ücretini girmek zorundasınız!");
            RuleFor(x => x.TahlilAdi).Must(SameIsNotExist).WithMessage("Bu Bu Tahlil Zaten Oluşturuldu Lütfen Aşağıdan İçeriğini Ekleyiniz!");
        }
        public bool SameIsNotExist(string tahliladi)
        {
            using (var hstn = new HastaneEntities())
            {
                return !hstn.Tahliller.Any(x => x.TahlilAdi == tahliladi);
            }
        }
    }
}
