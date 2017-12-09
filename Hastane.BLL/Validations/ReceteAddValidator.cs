using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Validations
{
     public class ReceteAddValidator : AbstractValidator<Receteler>
    {
        public ReceteAddValidator()
        {
            RuleFor(x => x.KabulID).Must(SameIsNotExist).WithMessage("Bu Hasta İçin Zaten Bir Reçete Oluşturuldu Lütfen Aşağıdan İlaçları Ekleyiniz!");
        }

        public bool SameIsNotExist(int kabulId)
        {
            using (var hstn = new HastaneEntities())
            {
                return !hstn.Receteler.Any(x => x.KabulID == kabulId);
            }
        }
    }
}
