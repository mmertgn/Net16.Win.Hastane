using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Models
{
    interface IKlinik
    {
        List<Klinikler> GetAllKlinikler();
        bool KlinikKaydet(Klinikler entity);
        bool KlinikGuncelle(Klinikler entity);
        bool KlinikSil(Klinikler entity);
        bool KlinikSil(int ID);
    }
}
