using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Validations
{
    public class TeshisAddValidator : AbstractValidator<Teshisler>
    {
        public TeshisAddValidator()
        {
            RuleFor(x => x.Teshis).NotEmpty().WithMessage("Hastanın teşhisini girmek zorundasınız!");
            RuleFor(x => x.KabulID).Must(SameIsNotExist).WithMessage("Bu Hasta İçin Teşhis Zaten Girildi. Değişiklik Yapmak İsterseniz Güncelle Butonunu Kullanabilirsiniz!");
        }
        public bool SameIsNotExist(int kabulId)
        {
            using (var hstn = new HastaneEntities())
            {
                return !hstn.Teshisler.Any(x => x.KabulID != kabulId);
            }
        }
    }
    public class TeshisUpdateValidator : AbstractValidator<Teshisler>
    {
        public TeshisUpdateValidator()
        {
            RuleFor(x => x.Teshis).NotEmpty().WithMessage("Hastanın şikayetini girmek zorundasınız!");
        }
    }
}
