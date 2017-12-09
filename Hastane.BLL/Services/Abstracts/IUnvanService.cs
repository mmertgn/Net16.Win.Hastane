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
    public interface IUnvanService
    {
        MessageResult Create(Unvanlar model);
        MessageResult Edit(Unvanlar model);
        MessageResult Delete(int id);
        List<Unvanlar> UnvanList();
        List<Unvanlar> UnvanListWithSorgu(Expression<Func<Unvanlar, bool>> predicate);
        Unvanlar GetUnvanById(int id);
        List<UnvanListesiModelFromSistemYonetim> UnvanBilgisiDoldur();
        List<UnvanListesiModelFromSistemYonetim> UnvanBilgisiDoldurAra(string Unvan);
    }
    public class UnvanListesiModelFromSistemYonetim
    {
        public int UnvanId { get; set; }
        public string PersonelUnvan { get; set; }

    }
}
