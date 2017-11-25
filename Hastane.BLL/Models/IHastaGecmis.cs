using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Models
{
    interface IHastaGecmis
    {
        bool HastaGecmisiKaydet(HastaGecmisi entity);
        bool HastaGecmisiGuncelle(HastaGecmisi entity);
        bool HastaGecmisiSil(HastaGecmisi entity);
        HastaGecmisi GetHastaGecmisiByID(int ID);
        HastaGecmisi GetHastaGecmisiByHastalar(Hastalar entity);
    }
}
