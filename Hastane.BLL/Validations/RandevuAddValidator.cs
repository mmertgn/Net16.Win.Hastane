using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Validations
{
    public class RandevuAddValidator : AbstractValidator<Randevular>
    {
        public RandevuAddValidator()
        {
            //Randevu kotnrolleri
            RuleFor(x => x.HastaID).NotEmpty().WithMessage("Hastayı sol taraftaki listeden seçmek zorundasınız!");
            RuleFor(x => x.Saat).NotEmpty().WithMessage("Bir Randevu Saati Seçmek Zorundasınız!");
        }
    }
    public class RandevuUpdateValidator : AbstractValidator<Randevular>
    {
        public RandevuUpdateValidator(int HastaId)
        {
            //Randevu kotnrolleri
            RuleFor(x => x.HastaID).NotEmpty().WithMessage("Hastayı sol taraftaki listeden seçmek zorundasınız!");
           
        }
    }
}
