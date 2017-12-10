using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Services.Abstracts
{
   public  interface IHastaTahlilSonuclariService
    {
        List<HastaTahlilSonuclari> HizmetList();
        List<HastaTahlilSonuclari> HizmetListWithSorgu(Expression<Func<HastaTahlilSonuclari, bool>> predicate);
    }
}
