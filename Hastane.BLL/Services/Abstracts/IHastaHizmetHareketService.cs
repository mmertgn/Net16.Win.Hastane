using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Models;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Services.Abstracts
{
    public interface IHastaHizmetHareketService
    {
        MessageResult Create(HastaHizmetHareketler model);
        MessageResult Edit(HastaHizmetHareketler model);
        MessageResult Delete(int id);
        List<HastaHizmetHareketler> HizmetHareketList();
        List<HastaHizmetHareketler> HizmetHareketListWithSorgu(Expression<Func<HastaHizmetHareketler, bool>> predicate);
        HastaHizmetHareketler GetHizmetHareketById(int id);
    }
}
