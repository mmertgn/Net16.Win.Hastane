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
            RuleFor(x => x.HastaID).NotEmpty().WithMessage("Hastayı sol taraftaki listeden seçmek zorundasınız!");



            //asdfghjkl
            RuleFor(x => x.Saat).NotEmpty().WithMessage("Bir Randevu Saati Seçmek Zorundasınız!");
        }
    }
}
