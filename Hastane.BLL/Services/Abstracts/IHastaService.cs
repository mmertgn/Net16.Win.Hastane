using Hastane.BLL.Models;
using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Services.Abstracts
{
    public interface IHastaService
    {
        MessageResult Create(Hastalar model);
        MessageResult Edit(Hastalar model);
        MessageResult Delete(int id);
        List<Hastalar> HastaList();
        List<Hastalar> Where(Expression<Func<Hastalar, bool>> predicate);
        Hastalar GetHastaById(int id);
        int Save();
    }
}
