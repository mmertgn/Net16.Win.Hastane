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
    public interface IKurumService
    {
        MessageResult Create(Kurumlar model);
        MessageResult Edit(Kurumlar model);
        MessageResult Delete(int id);
        List<Kurumlar> KurumList();
        List<Kurumlar> KurumListWithSorgu(Expression<Func<Kurumlar, bool>> predicate);
        Kurumlar GetKurumById(int id);
        List<KurumListesiModelFromSistemYonetim> KurumBilgisiDoldur();
        List<KurumListesiModelFromSistemYonetim> KurumBilgisiDoldurAra(string KurumAd, string KurumIskonto);
    }
    public class KurumListesiModelFromSistemYonetim
    {
        public int KurumId { get; set; }
        public string KurumAd { get; set; }
        public string KurumIskonto { get; set; }

    }
}
