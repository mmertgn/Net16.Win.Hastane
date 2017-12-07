using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Validations
{
    public class HastaSikayetiAddValidator : AbstractValidator<HastaSikayetleri>
    {
        public HastaSikayetiAddValidator()
        {
            RuleFor(x => x.Aciklama).NotEmpty().WithMessage("Hastanın şikayetini girmek zorundasınız!");
            RuleFor(x => x.KabulID).Must(SameIsNotExist).WithMessage("Bu Hasta İçin Hasta Şikayeti Zaten Girildi. Değişiklik Yapmak İsterseniz Güncelle Butonunu Kullanabilirsiniz!");
        }

        public bool SameIsNotExist(int kabulId)
        {
            using (var hstn = new HastaneEntities())
            {
                return !hstn.HastaSikayetleri.Any(x => x.KabulID != kabulId);
            }
        }
    }
    public class HastaSikayetiUpdateValidator : AbstractValidator<HastaSikayetleri>
    {
        public HastaSikayetiUpdateValidator()
        {
            RuleFor(x => x.Aciklama).NotEmpty().WithMessage("Hastanın şikayetini girmek zorundasınız!");
        }
        
    }
}
