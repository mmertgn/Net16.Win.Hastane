using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Models;
using Hastane.DAL.DataModel;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Hastane.BLL.Services.Abstracts
{
    public interface IKlinikService
    {
        MessageResult Create(Klinikler model);
        MessageResult Edit(Klinikler model);
        MessageResult Delete(int id);
        List<Klinikler> KlinikList();
        List<Klinikler> KlinikListWithSorgu(Expression<Func<Klinikler, bool>> predicate);
        Klinikler GetKlinikById(int id);
     
        List<KlinikListesiModelFromSistemYonetim> KlinikBilgisiDoldur();

        List<KlinikListesiModelFromSistemYonetim> KlinikBilgisiDoldurAra(string KlinikAd, string KlinikAciklama);


    }

    public class KlinikListesiModelFromSistemYonetim
    {
        public int KlinikId { get; set; }
        public string KlinikAd { get; set; }
        public string KlinikAciklama { get; set; }

    }


}
